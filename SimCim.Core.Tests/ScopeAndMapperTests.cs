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
        public IInfrastructureObject Create(IInfrastructureObjectScope scope, CimInstance cimInstance)
        {
            if(cimInstance.CimSystemProperties.ClassName.ToUpperInvariant() == "WIN32_PROCESS")
                return new Win32Process(scope, cimInstance);
            return new InstanceModificationEvent(scope, cimInstance);
        }
        public string TryResolveType(Type wrapperType)
        {
            if (wrapperType == typeof(Win32Process))
            {
                return "Win32_Process";
            }
            if (wrapperType == typeof(InstanceModificationEvent))
            {
                return  "__InstanceModificationEvent";
            }
            return null;
        }

        public string CimNamespace => "root/cimv2";
    }
    public class ScopeAndMapperTests
    {

        [Fact]
        public void TestEnumerateQueryUsingMapper()
        {
            using (var scope = new SimCimScope(new TestMapper()))
            {
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
            using (var scope = new SimCimScope(new TestMapper()))
            {
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
            using (var scope = new SimCimScope(new TestMapper()))
            {
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
            using (var scope = new SimCimScope(new TestMapper()))
            {
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
