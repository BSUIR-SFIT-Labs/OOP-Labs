using System.ComponentModel;

namespace OOP_Labs.Model.Cabinet
{
    class Lecture : Cabinet
    {
        [Description("Microphone exist")]
        public bool IsMicrophoneExist { get; set; }

        [Description("Speakers exist")]
        public bool IsSpeakersExist { get; set; }

        [Description("Projector exist")]
        public bool IsProjectorExist { get; set; }
    }
}
