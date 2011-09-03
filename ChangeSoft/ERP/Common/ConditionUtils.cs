using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;

namespace Com.ChangeSoft.Common
{
    public class ConditionUtils
    {

        public const String COND_LANGUAGE = "Language";

        private static  Hashtable _conditions = new Hashtable();

        public static void GetAllConditionsList(String lang)
        {

            XmlReader reader = new XmlTextReader("Conditions.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            XmlNode root = doc.DocumentElement;
            XmlNodeList conditionlist = root.SelectNodes("Condition/Name");
            foreach (XmlNode conditionnode in conditionlist)
            {
                IList<ConditionVo> result = new List<ConditionVo>();
                String condition = conditionnode.InnerText;
                XmlNodeList nodelist = root.SelectNodes("Condition[Name='" + condition + "']/Data[Language='" + lang + "']/List/Item");
                foreach (XmlNode node in nodelist)
                {
                    ConditionVo vo = new ConditionVo();
                    vo.ConditionValue = node.Attributes["value"].Value;
                    vo.ConditionName = node.InnerText;
                    result.Add(vo);
                }
                Conditions.Add(condition, result);
            }
            reader.Close();
        }

        public static String GetConditionName(String condition,String value)
        {
            IList conditionlist = (IList)Conditions[condition];
            String name = "";
            foreach (ConditionVo vo in conditionlist)
            {
                if (vo.ConditionValue.Equals(value))
                {
                    name =  vo.ConditionName;
                    break;
                }
            }
            return name;
        }

        public static Hashtable Conditions
        {
            get { return _conditions; }
            set { _conditions = value; }
        }

    }

    public class ConditionVo
    {
        private String _value;
        private String _name;
        public virtual String ConditionValue
        {
            get { return _value; }
            set { _value = value; }
        }
        public virtual String ConditionName
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
