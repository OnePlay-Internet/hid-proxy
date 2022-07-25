﻿using DevSim.Enums;
using System.Runtime.Serialization;

namespace DevSim.Models.RemoteControlDtos
{
    [DataContract]
    public class AudioSampleDto : BaseDto
    {
        public AudioSampleDto(byte[] buffer)
        {
            Buffer = buffer;
        }

        [DataMember(Name = "Buffer")]
        public byte[] Buffer { get; }


        [DataMember(Name = "DtoType")]
        public override BaseDtoType DtoType { get; init; } = BaseDtoType.AudioSample;

    }
}