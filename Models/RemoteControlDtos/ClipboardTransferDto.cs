﻿using DevSim.Enums;
using System.Runtime.Serialization;

namespace DevSim.Models.RemoteControlDtos
{
    [DataContract]
    public class ClipboardTransferDto : BaseDto
    {

        [DataMember(Name = "Text")]
        public string Text { get; set; }

        [DataMember(Name = "TypeText")]
        public bool TypeText { get; set; }


        [DataMember(Name = "DtoType")]
        public override BaseDtoType DtoType { get; init; } = BaseDtoType.ClipboardTransfer;
    }
}