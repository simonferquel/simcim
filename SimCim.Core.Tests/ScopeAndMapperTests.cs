using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimCim.Core.Tests
{
    public class Win32Process : GenericInfrastructureObject
    {
        public Win32Process() { }
        public Win32Process(IInfrastructureObjectScope scope, CimInstance instance) : base(scope, instance) { }
    }

    public class InstanceModificationEvent: GenericInfrastructureObject
    {
        public InstanceModificationEvent() { }
        public InstanceModificationEvent(IInfrastructureObjectScope scope, CimInstance instance) : base(scope, instance) { }

    }

    public class TestMapper : IInfrastructureObjectMapper
    {
        private readonly IInfrastructureObjectScope _scope;

        public TestMapper(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }
        public IInfrastructureObject Create(CimInstance cimInstance)
        {
            if(cimInstance.CimSystemProperties.ClassName.ToUpperInvariant() == "WIN32_PROCESS")
                return new Win32Process(_scope, cimInstance);
            return new InstanceModificationEvent(_scope, cimInstance);
        }
        public (string cimNamespace, string cimClassName) TryResolveType(Type wrapperType)
        {
            if (wrapperType == typeof(Win32Process))
            {
                return ("root/cimv2", "Win32_Process");
            }
            if (wrapperType == typeof(InstanceModificationEvent))
            {
                return ("root/cimv2", "__InstanceModificationEvent");
            }
            return (null, null);
        }
    }
    public class ScopeAndMapperTests
    {
        [Fact]
        public void TestFallbackToGenericObject()
        {
            using (var scope = new SimCimScope())
            {
                var pInstance = scope.CimSession.EnumerateInstances("root/cimv2", "Win32_PRocess").First();
                var result = scope.Mapper.Create(pInstance);
                Assert.NotNull(result);
                Assert.IsType<GenericInfrastructureObject>(result);
            }
        }

        [Fact]
        public void TestEnumerateQueryUsingMapper()
        {
            using (var scope = new SimCimScope())
            {
                scope.Mapper.AddNamespaceMapper("root/cimv2", new TestMapper(scope));
                var processes = scope.EnumerateInstances<Win32Process>().ToList();
                Assert.NotEmpty(processes);
                var process = processes[0];
                Assert.IsType<Win32Process>(process);
                process.GetProperty("ProcessId", out uint processId);
                var queryResult = scope.QueryInstances<Win32Process>($"ProcessId = {processId}").ToList();
                Assert.Single(queryResult);
            }
        }

        [Fact]
        public async Task TestEnumerateQueryAsyncUsingMapper()
        {
            using (var scope = new SimCimScope())
            {
                scope.Mapper.AddNamespaceMapper("root/cimv2", new TestMapper(scope));
                var processesAsync = scope.EnumerateInstancesAsync<Win32Process>().ToAsyncEnumerable();
                var processes = await processesAsync.ToListAsync();
                Assert.NotEmpty(processes);
                var process = processes[0];
                Assert.IsType<Win32Process>(process);
                process.GetProperty("ProcessId", out uint processId);
                var queryResult = await scope.QueryInstancesAsync<Win32Process>($"ProcessId = {processId}").ToAsyncEnumerable().ToListAsync();
                Assert.Single(queryResult);
            }
        }

        [Fact]
        public async Task TestEventsNoPolling()
        {
            using (var scope = new SimCimScope())
            {
                scope.Mapper.AddNamespaceMapper("root/cimv2", new TestMapper(scope));
                var events = scope.SubscribeToEvents<InstanceModificationEvent>(filter: "TargetInstance ISA 'Win32_LocalTime'");
                await foreach (var ev in events.ToAsyncEnumerable())
                {
                    // check for get infrastructure object property
                    GenericInfrastructureObject time;
                    ev.Event.GetInfrastructureObjectProperty("TargetInstance", out time);
                    Assert.NotNull(time);
                    return;
                }
            }
        }
        [Fact]
        public async Task TestEventsPolling()
        {
            using (var scope = new SimCimScope())
            {
                scope.Mapper.AddNamespaceMapper("root/cimv2", new TestMapper(scope));
                var events = scope.SubscribeToEvents<InstanceModificationEvent>(pollingIntervalSeconds:1, filter: "TargetInstance ISA 'Win32_LocalTime'");
                await foreach (var ev in events.ToAsyncEnumerable())
                {
                    // check for get infrastructure object property
                    GenericInfrastructureObject time;
                    ev.Event.GetInfrastructureObjectProperty("TargetInstance", out time);
                    Assert.NotNull(time);
                    return;
                }
            }
        }
    }
}
