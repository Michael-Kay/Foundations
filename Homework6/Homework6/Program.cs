// File: tv.cs
class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    public bool IsOn
    {
        get
        {
            return isOn;
        }
        set
        {
            isOn = value;
        }
    }
    public void TurnOn()
    {
        isOn = true;
        // do the code to turn the tv on
    }
    public void TurnOff()
    {
        isOn = false;
        // do the code to turn the tv off
    }

    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = value;
        }
    }

    public int CurrentVolume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = value;
        }
    }


    public void IncreaseVolume()
    {
        if (volume < 100)
        {
            volume = volume + 1;
            // do the code to increase the volume
        }
    }
    public void DecreaseVolume()
    {
        if (volume > 0)
        {
            volume = volume - 1;
            // do the code to decrease the volume
        }
    }

    public int Channel
    {
        get
        {
            return channel;
        }
        set
        {
            channel = value;
        }
    }

    public int CurrentChannel
    {
        get
        {
            return channel;
        }
        set
        {
           channel = value;
        }
    }

    public void ChangeChannel(int Channel)
    {
        if (Channel > 0 && Channel < 50)
        {
            channel = Channel;
            // do the code to change the
            // channel on the tv
        }
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn)
        {
            tv.IsOn = true;
        }

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.IsOn = false;
    }
}
