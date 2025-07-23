using CommandLine;

namespace TESSwitch;

public class Options
{
    [Option('p', "port", Required = false, Default = 5000, HelpText = "The TES connection port.")]
    public int Port { get; set; }
    [Option('i', "ip", Required = false, Default = "192.168.1.10", HelpText = "The TES internet protocol.")]
    public string? IP { get; set; }
    [Option('c', "channel", Required = true, HelpText = "The channel to switch to (0-16).")]
    public int Channel { get; set; }
}