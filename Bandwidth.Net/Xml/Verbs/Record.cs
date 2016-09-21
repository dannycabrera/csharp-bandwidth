﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Net.Xml.Verbs
{
    /// <summary>
    /// The Record verb allow call recording.
    /// </summary>
    /// <seealso href="http://ap.bandwidth.com/docs/xml/record/"/>
    public class Record: IVerb
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Record()
        {
            MaxDuration = 300;
        }
        /// <summary>
        /// Relative or absolute URL to send event and request new BaML 
        /// </summary>
        [XmlAttribute("requestUrl")]
        public string RequestUrl { get; set; }

        /// <summary>
        /// The time in milliseconds to wait for requestUrl response
        /// </summary>
        [XmlAttribute("requestUrlTimeout"), DefaultValue(0)]
        public int RequestUrlTimeout { get; set; }

        /// <summary>
        /// One or more digits that will finish the recording
        /// </summary>
        [XmlAttribute("terminatingDigits")]
        public string TerminatingDigits { get; set; }
        
        /// <summary>
        /// The time in second for max recording duration
        /// </summary>
        [XmlAttribute("maxDuration"), DefaultValue(300)]
        public int MaxDuration { get; set; }

        /// <summary>
        /// A boolean value to indicate that recording must be transcribed 
        /// </summary>
        [XmlAttribute("transcribe")]
        public bool Transcribe { get; set; }

        /// <summary>
        /// Relative or absolute URL to send transcribed event 
        /// </summary>
        [XmlAttribute("transcribeCallbackUrl")]
        public string TranscribeCallbackUrl { get; set; }

        /// <summary>
        /// The file format of the recorded call.
        /// </summary>
        [XmlAttribute("recordingFileFormat")]
        public string RecordingFileFormat { get; set; }
  }
}