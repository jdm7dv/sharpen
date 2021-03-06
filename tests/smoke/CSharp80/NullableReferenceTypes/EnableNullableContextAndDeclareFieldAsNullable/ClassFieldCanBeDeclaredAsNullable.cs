﻿// ReSharper disable All

// Expected number of suggestions: 58

namespace CSharp80.NullableReferenceTypes.EnableNullableContextAndDeclareFieldAsNullable
{
    public class ClassFieldCanBeDeclaredAsNullable
    {
        private string detectedOnlyOnce = null;

        private string intializedToNull = null;
        private string initializedToResultOfAsOperator = string.Empty as string;

        private string a, bAssignedNull, c;
        private string d, e, fInitializedToNull = null;
        private string gInitializedToResultOfAsOperator = string.Empty as string, h, i;

        private string assignedNull;
        private string comparedEqualToNullOnLeft;
        private string comparedEqualToNullOnRight;
        private string comparedNotEqualToNullOnLeft;
        private string comparedNotEqualToNullOnRight;
        private string assignedResultOfAsOperator;
        private string usedInConditionalAccess;
        private string usedInCoalesceExpression;

        private string assignedNullUsingThis;
        private string comparedEqualToNullOnLeftUsingThis;
        private string comparedEqualToNullOnRightUsingThis;
        private string comparedNotEqualToNullOnLeftUsingThis;
        private string comparedNotEqualToNullOnRightUsingThis;
        private string assignedResultOfAsOperatorUsingThis;
        private string usedInConditionalAccessUsingThis;
        private string usedInCoalesceExpressionUsingThis;

        private static string StaticAssignedNull;
        private static string StaticComparedEqualToNullOnLeft;
        private static string StaticComparedEqualToNullOnRight;
        private static string StaticComparedNotEqualToNullOnLeft;
        private static string StaticComparedNotEqualToNullOnRight;
        private static string StaticAssignedResultOfAsOperator;
        private static string StaticUsedInConditionalAccess;
        private static string StaticUsedInCoalesceExpression;

        private static string StaticAssignedNullUsingClassName;
        private static string StaticComparedEqualToNullOnLeftUsingClassName;
        private static string StaticComparedEqualToNullOnRightUsingClassName;
        private static string StaticComparedNotEqualToNullOnLeftUsingClassName;
        private static string StaticComparedNotEqualToNullOnRightUsingClassName;
        private static string StaticAssignedResultOfAsOperatorUsingClassName;
        private static string StaticUsedInConditionalAccessUsingClassName;
        private static string StaticUsedInCoalesceExpressionUsingClassName;

        public void AllFieldsAreNullableForDifferentReasons()
        {
            string dummy;

            assignedNull = null;
            bAssignedNull = null;
            detectedOnlyOnce = null;

            if (comparedEqualToNullOnLeft == null) return;
            if (null == comparedEqualToNullOnRight) return;            
            if (comparedNotEqualToNullOnLeft != null) return;
            if (null != comparedNotEqualToNullOnRight) return;
            if (detectedOnlyOnce == null) return;
            if (null == detectedOnlyOnce) return;

            assignedResultOfAsOperator = assignedNull as string;
            detectedOnlyOnce = assignedNull as string;

            usedInConditionalAccess?.Length.ToString();
            detectedOnlyOnce?.Length.ToString();

            dummy = usedInCoalesceExpression ?? string.Empty;
            dummy = detectedOnlyOnce ?? string.Empty;

            this.assignedNullUsingThis = null;

            if (this.comparedEqualToNullOnLeftUsingThis == null) return;
            if (null == this.comparedEqualToNullOnRightUsingThis) return;
            if (this.comparedNotEqualToNullOnLeftUsingThis != null) return;
            if (null != this.comparedNotEqualToNullOnRightUsingThis) return;

            this.assignedResultOfAsOperatorUsingThis = assignedNull as string;
            this.usedInConditionalAccessUsingThis?.Length.ToString();
            dummy = this.usedInCoalesceExpressionUsingThis ?? string.Empty;

            StaticAssignedNull = null;

            if (StaticComparedEqualToNullOnLeft == null) return;
            if (null == StaticComparedEqualToNullOnRight) return;
            if (StaticComparedNotEqualToNullOnLeft != null) return;
            if (null != StaticComparedNotEqualToNullOnRight) return;

            StaticAssignedResultOfAsOperator = assignedNull as string;
            StaticUsedInConditionalAccess?.Length.ToString();
            dummy = StaticUsedInCoalesceExpression ?? string.Empty;

            ClassFieldCanBeDeclaredAsNullable.StaticAssignedNullUsingClassName = null;

            if (ClassFieldCanBeDeclaredAsNullable.StaticComparedEqualToNullOnLeftUsingClassName == null) return;
            if (null == ClassFieldCanBeDeclaredAsNullable.StaticComparedEqualToNullOnRightUsingClassName) return;
            if (ClassFieldCanBeDeclaredAsNullable.StaticComparedNotEqualToNullOnLeftUsingClassName != null) return;
            if (null != ClassFieldCanBeDeclaredAsNullable.StaticComparedNotEqualToNullOnRightUsingClassName) return;

            ClassFieldCanBeDeclaredAsNullable.StaticAssignedResultOfAsOperatorUsingClassName = assignedNull as string;
            ClassFieldCanBeDeclaredAsNullable.StaticUsedInConditionalAccessUsingClassName?.Length.ToString();
            dummy = ClassFieldCanBeDeclaredAsNullable.StaticUsedInCoalesceExpressionUsingClassName ?? string.Empty;

            var classWithFields = new ClassWithNullableFields();

            classWithFields.assignedNull = null;

            if (classWithFields.comparedEqualToNullOnLeft == null) return;
            if (null == classWithFields.comparedEqualToNullOnRight) return;
            if (classWithFields.comparedNotEqualToNullOnLeft != null) return;
            if (null != classWithFields.comparedNotEqualToNullOnRight) return;

            classWithFields.assignedResultOfAsOperator = assignedNull as string;
            classWithFields.usedInConditionalAccess?.Length.ToString();
            dummy = classWithFields.usedInCoalesceExpression ?? string.Empty;

            ClassWithNullableFields.StaticAssignedNull = null;

            if (ClassWithNullableFields.StaticComparedEqualToNullOnLeft == null) return;
            if (null == ClassWithNullableFields.StaticComparedEqualToNullOnRight) return;
            if (ClassWithNullableFields.StaticComparedNotEqualToNullOnLeft != null) return;
            if (null != ClassWithNullableFields.StaticComparedNotEqualToNullOnRight) return;

            ClassWithNullableFields.StaticAssignedResultOfAsOperator = assignedNull as string;
            ClassWithNullableFields.StaticUsedInConditionalAccess?.Length.ToString();
            dummy = ClassWithNullableFields.StaticUsedInCoalesceExpression ?? string.Empty;

            var anotherClassWithFields = new ClassWithNullableFields
            {
                intializedToDefaultInInitializationList = default,
                intializedToNullInInitializationList = null,
                intializedToResultOfAsOperatorInInitializationList = string.Empty as string
            };
        }
    }

    public class ClassWithNullableFields
    {
        public string intializedToNull = null;

        public string assignedNull;
        public string comparedEqualToNullOnLeft;
        public string comparedEqualToNullOnRight;
        public string comparedNotEqualToNullOnLeft;
        public string comparedNotEqualToNullOnRight;
        public string assignedResultOfAsOperator;
        public string usedInConditionalAccess;
        public string usedInCoalesceExpression;

        public string intializedToDefaultInInitializationList;
        public string intializedToNullInInitializationList;
        public string intializedToResultOfAsOperatorInInitializationList;

        public static string StaticAssignedNull;
        public static string StaticComparedEqualToNullOnLeft;
        public static string StaticComparedEqualToNullOnRight;
        public static string StaticComparedNotEqualToNullOnLeft;
        public static string StaticComparedNotEqualToNullOnRight;
        public static string StaticAssignedResultOfAsOperator;
        public static string StaticUsedInConditionalAccess;
        public static string StaticUsedInCoalesceExpression;
    }
}