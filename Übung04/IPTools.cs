using System;
using System.Globalization;

static class IPTools
{
    public readonly static byte[] LocalHost = new byte[]{127, 0, 0, 0};

    public static string IPAddressToString(byte[] address)
    {
        if(address.Length == 4)
        {
            return IPv4AddressToString(address);
        }
        else if(address.Length == 16)
        {
            return IPv6AddressToString(address);
        }
        else
        {
            throw new ArgumentException("invalid IP address - only 4 or 8 bytes");
        }
    }

    public static byte[] STringToIPAddress(string value)
    {
        if(value.Contains('.'))
        {
            return StringToIPv4Address(value);
        }
        else if (value.Contains(':'))
        {
            return StringToIPv6Address(value);
        }
        else
        {
            throw new ArgumentException("Invalid IP address string!");
        }
    }

    private static string IPv4AddressToString(byte[] address)
    {
        return $"{address[0]}.{address[1]}.{address[2]}.{address[3]}";
    }

    private static string IPv6AddressToString(byte[] address)
    {
        var comp = new string[8];
        for(int i = 0; i<8; i++)
        {
            comp[i] = address[2*i].ToString("x2") + address[2*i+1].ToString("x2");
        }

        return string.Join(":", comp);
    }

    private static byte[] StringToIPv4Address(string value)
    {
        var comps = value.Split('.');
        if(comps.Length != 4)
        {
            throw new ArgumentException("Expected four IPv4 components!");
        }

        var result = new byte[4];
        for(int i = 0; i<4; i++)
        {
            result[i] = byte.Parse(comps[i]);
        }

        return result;
    }

    private static byte[] StringToIPv6Address(string value)
    {
        var comps = value.Split(':');
        if(comps.Length != 8)
        {
            throw new ArgumentException("Expected eight IPv6 components!");
        }

        var result = new byte[16];
        for(int i = 0; i<8; i++)
        {
            var comp = comps[i];
            if(comp.Length != 4)
            {
                throw new ArgumentException("Expected four digits in IPv6 component!");

            }

            var substrings = new string[] {comp.Substring(0,2),comp.Substring(2)};

            for (int j = 0; j<2; j++)
            {
                result[(2*i)+j] = byte.Parse(substrings[j], NumberStyles.AllowHexSpecifier);
            }
        }

        return result;

    }

}