using System.Globalization;
namespace TESSwitch;

public static class Helpers
{
    public static byte[] ConvertHexStringToByteArray(string hexString)
    {
        if (hexString.Length % 2 != 0)
        {
            throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Odd number of digits: {0}", hexString));
        }

        var data = new byte[hexString.Length / 2];
        for (var index = 0; index < data.Length; index++)
        {
            var byteValue = hexString.Substring(index * 2, 2);
            data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        }

        return data; 
    }
    
    public static string HexFromChannel(int channel)
    {
        return channel switch
        {
            1 => "01",
            2 => "02",
            3 => "03",
            4 => "04",
            5 => "05",
            6 => "06",
            7 => "07",
            8 => "08",
            9 => "09",
            10 => "0A",
            11 => "0B",
            12 => "0C",
            13 => "0D",
            14 => "0E",
            15 => "0F",
            16 => "10",
            _ => "00"
        };
    }
}