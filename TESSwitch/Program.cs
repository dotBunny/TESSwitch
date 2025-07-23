using System.Net.Sockets;
using CommandLine;
using TESSwitch;

Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(o =>
    {
        try
        {
            using var client = new TcpClient();
            if (string.IsNullOrEmpty(o.IP))
            {
                throw new Exception("No IP address specified.");
            }
            client.Connect(o.IP, o.Port);
            using var stream = client.GetStream();
            var commandBytes = Helpers.ConvertHexStringToByteArray("AABB0301" + Helpers.HexFromChannel(o.Channel) + "EE");
            stream.Write(commandBytes, 0, commandBytes.Length);
        }
        catch (SocketException ex)
        {
            Console.WriteLine($"Socket error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    })
    .WithNotParsed(errors =>
    {
        Console.WriteLine("Error parsing arguments.");
    });
