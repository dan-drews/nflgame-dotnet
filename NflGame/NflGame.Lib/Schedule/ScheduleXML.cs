using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NflGame.Lib.Schedule
{
    public class ScheduleXML
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class ss
        {

            private ssGms gmsField;

            private string[] textField;

            /// <remarks/>
            public ssGms gms
            {
                get
                {
                    return this.gmsField;
                }
                set
                {
                    this.gmsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ssGms
        {

            private ssGmsG[] gField;

            private string tField;

            private ushort yField;

            private byte wField;

            private byte gdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("g")]
            public ssGmsG[] g
            {
                get
                {
                    return this.gField;
                }
                set
                {
                    this.gField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string t
            {
                get
                {
                    return this.tField;
                }
                set
                {
                    this.tField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte w
            {
                get
                {
                    return this.wField;
                }
                set
                {
                    this.wField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte gd
            {
                get
                {
                    return this.gdField;
                }
                set
                {
                    this.gdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ssGmsG
        {

            private string tField;

            private string gtField;

            private string gaField;

            private string rzField;

            private string pField;

            private string vsField;

            private string vnnField;

            private string vField;

            private string hsField;

            private string hnnField;

            private string hField;

            private string kField;

            private string qField;

            private string dField;

            private ushort gsisField;

            private uint eidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string t
            {
                get
                {
                    return this.tField;
                }
                set
                {
                    this.tField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string gt
            {
                get
                {
                    return this.gtField;
                }
                set
                {
                    this.gtField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ga
            {
                get
                {
                    return this.gaField;
                }
                set
                {
                    this.gaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rz
            {
                get
                {
                    return this.rzField;
                }
                set
                {
                    this.rzField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string p
            {
                get
                {
                    return this.pField;
                }
                set
                {
                    this.pField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string vs
            {
                get
                {
                    return this.vsField;
                }
                set
                {
                    this.vsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string vnn
            {
                get
                {
                    return this.vnnField;
                }
                set
                {
                    this.vnnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string v
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string hs
            {
                get
                {
                    return this.hsField;
                }
                set
                {
                    this.hsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string hnn
            {
                get
                {
                    return this.hnnField;
                }
                set
                {
                    this.hnnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string h
            {
                get
                {
                    return this.hField;
                }
                set
                {
                    this.hField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string k
            {
                get
                {
                    return this.kField;
                }
                set
                {
                    this.kField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string q
            {
                get
                {
                    return this.qField;
                }
                set
                {
                    this.qField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string d
            {
                get
                {
                    return this.dField;
                }
                set
                {
                    this.dField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort gsis
            {
                get
                {
                    return this.gsisField;
                }
                set
                {
                    this.gsisField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint eid
            {
                get
                {
                    return this.eidField;
                }
                set
                {
                    this.eidField = value;
                }
            }
        }


    }
}
