﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xtUML1
{
    public class JsonData
    {
        public string type { get; set; }
        public string sub_id { get; set; }
        public string sub_name { get; set; }
        public List<Model> model { get; set; }
        public class Model
        {
            public string type { get; set; }
            public string class_id { get; set; }
            public string superclass_id { get; set; }
            public string class_name { get; set; }
            public string superclass_name { get; set; }
            public string KL { get; set; }
            public string name { get; set; }
            public List<Attribute1> attributes { get; set; }
            public List<Subclasses> subclasses { get; set; }
            public List<State> states { get; set; }
            public Model model { get; set; }
            public List<Class1> @class { get; set; }
        }

        public class Subclasses
        {
            public string class_id { get; set; }
            public string class_name { get; set; }
        }

        public class Attribute1
        {
            public string attribute_name { get; set; }
            public string data_type { get; set; }
            public string default_value { get; set; }
            public string attribute_type { get; set; }
            public string event_id { get; set; }
            public string event_name { get; set; }
            public string class_id { get; set; }
            public string state_id { get; set; }
            public string state_name { get; set; }
            public string related_class_id { get; set; }
            public string related_class_name { get; set; }
            public string related_class_KL { get; set; }
        }

        public class State
        {
            public string state_id { get; set; }
            public string state_name { get; set; }
            public string state_value { get; set; }
            public string state_type { get; set; }
            public object state_event { get; set; }
            public string[] state_function { get; set; }
            public string[] state_transition_id { get; set; }
            public List<Transition> transitions { get; set; }
            public string action { get; set; }
        }

        public class Class1
        {
            public string class_name { get; set; }
            public string class_multiplicity { get; set; }
            public List<Attribute> attributes { get; set; }
            public List<Class1> @class { get; set; }
        }

        public class ClassModel
        {
            public string ClassId { get; set; }
            public string SuperClassId { get; set; }
            public List<ClassModel> SubClasses { get; set; }
            public string ClassName { get; set; }
            public string SuperClassName { get; set; }
            public string KL { get; set; }
            public List<AttributeModel> Attributes { get; set; }
        }

        public class AttributeModel
        {
            public string AttributeType { get; set; }
            public string AttributeName { get; set; }
            public string DataType { get; set; }
            public string RoleName { get; set; }

        }

        public class AssociationModel
        {
            public string Name { get; set; }
            public List<AssocClass> Classes { get; set; }
            public ClassModel AssociationClass { get; set; }
        }

        public class AssocClass
        {
            public string ClassId { get; set; }
            public string ClassName { get; set; }
            public string Multiplicity { get; set; }
            public string RoleName { get; set; }

        }
        public class Attribute
        {
            public string attribute_name { get; set; }
            public string data_type { get; set; }
            public string attribute_type { get; set; }
        }

        public class Transition
        {
            public string target_state_id { get; set; }
            public string target_state { get; set; }
            public string target_state_event { get; set; }
            public string parameter { get; set; }
        }
    }
}
