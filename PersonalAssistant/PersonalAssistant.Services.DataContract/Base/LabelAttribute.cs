namespace PersonalAssistant.Services.DataContract.Base
{
    using System;

    public class LabelAttribute : Attribute
    {
        public string Value { get; set; }
    }
}