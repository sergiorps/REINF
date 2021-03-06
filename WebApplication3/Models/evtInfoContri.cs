﻿using System.Xml.Serialization;

namespace WebApplication3.Models
{
    [XmlRoot(Namespace = "http://www.reinf.esocial.gov.br/schemas/evtInfoContribuinte/v1_02_00")]
    public class evtInfoContri
    {
        [XmlElement(Namespace = "http://www.reinf.esocial.gov.br/schemas/evtInfoContribuinte/v1_02_00")]
        public ideEvento ideEvento { get; set; }

        [XmlElement(Namespace = "http://www.reinf.esocial.gov.br/schemas/evtInfoContribuinte/v1_02_00")]
        public ideContri ideContri { get; set; }

        [XmlElement(Namespace = "http://www.reinf.esocial.gov.br/schemas/evtInfoContribuinte/v1_02_00")]
        public inclusao inclusao { get; set; }
    }
}