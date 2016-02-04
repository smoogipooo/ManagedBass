﻿using ManagedBass.Dynamics;
using System;
using System.Runtime.InteropServices;

namespace ManagedBass
{
    public class MixerStream : Channel
    {
        public MixerStream(int Frequency = 44100, int NoOfChannels = 2, bool IsDecoder = true, Resolution Resolution = Resolution.Short)
        {
            Handle = BassMix.CreateMixerStream(Frequency, NoOfChannels, FlagGen(IsDecoder, Resolution));
        }

        public override int Read(IntPtr Buffer, int Length)
        {
            return BassMix.ChannelGetData(Handle, Buffer, Length);
        }

        public bool AddChannel(Channel channel) { return AddChannel(channel.Handle); }

        public bool AddChannel(int channel) { return BassMix.MixerAddChannel(Handle, channel, BassFlags.Default); }

        public bool RemoveChannel(Channel channel) { return RemoveChannel(channel.Handle); }

        public bool RemoveChannel(int channel) { return BassMix.MixerRemoveChannel(channel); }
    }
}