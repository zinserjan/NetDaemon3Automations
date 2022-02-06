﻿// using System.Threading;
// using System.Threading.Tasks;
// using NetDaemon.Extensions.MqttEntityManager;
//
// namespace HomeAssistantGenerated.apps;
//
// [NetDaemonApp]
// [Focus]
// public class MqttTestApp : IAsyncInitializable
// {
//     private readonly IMqttEntityManager _mqttEntityManager;
//
//     public MqttTestApp(IMqttEntityManager mqttEntityManager)
//     {
//         _mqttEntityManager = mqttEntityManager;
//     }
//
//     public async Task InitializeAsync(CancellationToken cancellationToken)
//     {
//         try
//         {
//             // await _mqttEntityManager.CreateAsync("sensor", "testar_mqtt", "temperature", "testar_mqtt").ConfigureAwait(false);
//             await _mqttEntityManager.UpdateAsync("sensor", "testar_mqtt", "11");
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e);
//             throw;
//         }
//     }
// }
