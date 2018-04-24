﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCPDP_Parser.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class HisCompound1
    {
        [Key]
        public int Compound1ID { get; set; }
        public int DetailID { get; set; }
        public string RecordType { get; set; }
        public string Prescription_Reference_Number_Qualifier { get; set; }
        public string Prescription_Reference_Number { get; set; }
        public string Compound_Ingredient_Component_Count { get; set; }
        public string First_Compound_Product_ID_Qualifier { get; set; }
        public string First_Compound_Product_ID { get; set; }
        public string First_Compound_Ingredient_Quantity { get; set; }
        public string First_Compound_Ingredient_Drug_Cost { get; set; }
        public string First_Compound_Ingredient_Basis_Of_Cost_Determination { get; set; }
        public string First_Client_Formulary_Flag { get; set; }
        public string First_Product_Name { get; set; }
        public string First_Generic_Name { get; set; }
        public string First_Product_Strength { get; set; }
        public string First_Dosage_Form_Code { get; set; }
        public string First_Database_Indicator { get; set; }
        public string First_Drug_Type { get; set; }
        public string First_Formulary_Status { get; set; }
        public string First_Drug_Category_Code { get; set; }
        public string First_Federal_DEA_Schedule { get; set; }
        public string First_FDA_Drug_Efficacy_Code { get; set; }
        public string First_Product_Code_Qualifier1 { get; set; }
        public string First_Product_Code1 { get; set; }
        public string First_Product_Code_Qualifier2 { get; set; }
        public string First_Product_Code2 { get; set; }
        public string First_Product_Code_Qualifier3 { get; set; }
        public string First_Product_Code3 { get; set; }
        public string First_Federal_Upper_Limit_Indicator { get; set; }
        public string First_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string First_Therapeutic_Class_Code1 { get; set; }
        public string First_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string First_Therapeutic_Class_Code2 { get; set; }
        public string First_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string First_Therapeutic_Class_Code3 { get; set; }
        public string First_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string First_Therapeutic_Class_Code4 { get; set; }
        public string First_Special_Packaging_Indicator { get; set; }
        public string First_Unit_Of_Measure { get; set; }
        public string First_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string First_MAC_Reduced_Indicator { get; set; }
        public string First_Client_Pricing_Basis_Of_Cost { get; set; }
        public string First_DUR_Coagent_ID_Qualifier { get; set; }
        public string First_DUR_Coagent_ID { get; set; }
        public string First_Generic_Indicator { get; set; }
        public string First_Plan_Cutback_Reason_Code { get; set; }
        public string First_Therapeutic_Chapter { get; set; }
        public string First_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string First_Average_Generic_Unit_Price { get; set; }
        public string First_Average_Wholesale_Unit_Price { get; set; }
        public string First_Federal_Upper_Limit_Unit_Price { get; set; }
        public string First_MAC_Price { get; set; }
        public string First_Basis_Of_Reimbursement_Determination { get; set; }
        public string First_Patient_Formulary_Rebate_Amount { get; set; }
        public string Second_Compound_ID_Qualifier { get; set; }
        public string Second_Compound_ID { get; set; }
        public string Second_Compound_Ingredient_Quantity { get; set; }
        public string Second_Compound_Ingredient_Drug_Cost { get; set; }
        public string Second_Compound_Ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Second_Client_Formulary_Flag { get; set; }
        public string Second_Product_Name { get; set; }
        public string Second_Generic_Name { get; set; }
        public string Second_Product_Strength { get; set; }
        public string Second_Dosage_Form_Code { get; set; }
        public string Second_Database_Indicator { get; set; }
        public string Second_Drug_Type { get; set; }
        public string Second_Formulary_Status { get; set; }
        public string Second_Drug_Category_Code { get; set; }
        public string Second_Federal_DEA_Schedule { get; set; }
        public string Second_FDA_Drug_Efficacy_Code { get; set; }
        public string Second_Product_Code_Qualifier1 { get; set; }
        public string Second_Product_Code1 { get; set; }
        public string Second_Product_Code_Qualifier2 { get; set; }
        public string Second_Product_Code2 { get; set; }
        public string Second_Product_Code_Qualifier3 { get; set; }
        public string Second_Product_Code3 { get; set; }
        public string Second_Federal_Upper_Limit_Indicator { get; set; }
        public string Second_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Second_Therapeutic_Class_Code1 { get; set; }
        public string Second_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Second_Therapeutic_Class_Code2 { get; set; }
        public string Second_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Second_Therapeutic_Class_Code3 { get; set; }
        public string Second_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Second_Therapeutic_Class_Code4 { get; set; }
        public string Second_Special_Packaging_Indicator { get; set; }
        public string Second_Unit_Of_Measure { get; set; }
        public string Second_Proceddor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Second_MAC_Reduced_Indicator { get; set; }
        public string Second_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Second_DUR_Coagent_ID_Qualifier { get; set; }
        public string Second_DUR_Coagent_ID { get; set; }
        public string Second_Generic_Indicator { get; set; }
        public string Second_Plan_Cutback_Reason_Code { get; set; }
        public string Second_Therapeutic_Chapter { get; set; }
        public string Second_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Second_Average_Generic_Unit_Price { get; set; }
        public string Second_Average_Wholesale_Unit_Price { get; set; }
        public string Second_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Second_MAC_Price { get; set; }
        public string Second_Basis_Of_Reimbursement_Determination { get; set; }
        public string Second_Patient_Formulary_Rebate_Amount { get; set; }
        public string Third_Compound_ID_Qualifier { get; set; }
        public string Third_Compound_ID { get; set; }
        public string Third_Compound_Ingredient_Quantity { get; set; }
        public string Third_Compound_Ingredient_Drug_Cost { get; set; }
        public string Third_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Third_Client_Formulary_Flag { get; set; }
        public string Third_Product_Name { get; set; }
        public string Third_Generic_Name { get; set; }
        public string Third_Product_Strength { get; set; }
        public string Third_Dosage_Form_Code { get; set; }
        public string Third_Database_Indicator { get; set; }
        public string Third_Drug_Type { get; set; }
        public string Third_Formulary_Status { get; set; }
        public string Third_Drug_Category_Code { get; set; }
        public string Third_Federal_DEA_Schedule { get; set; }
        public string Third_FDA_Drug_Efficacy_Code { get; set; }
        public string Third_Product_Code_Qualifier1 { get; set; }
        public string Third_Product_Code1 { get; set; }
        public string Third_Product_Code_Qualifier2 { get; set; }
        public string Third_Product_Code2 { get; set; }
        public string Third_Product_Code_Qualifier3 { get; set; }
        public string Third_Product_Code3 { get; set; }
        public string Third_Federal_Upper_Limit_Indicator { get; set; }
        public string Third_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Third_Therapeutic_Class_Code1 { get; set; }
        public string Third_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Third_Therapeutic_Class_Code2 { get; set; }
        public string Third_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Third_Therapeutic_Class_Code3 { get; set; }
        public string Third_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Third_Therapeutic_Class_Code4 { get; set; }
        public string Third_Special_Packaging_Indicator { get; set; }
        public string Third_Unit_Of_Measure { get; set; }
        public string Third_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Third_MAC_Reduced_Indicator { get; set; }
        public string Third_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Third_DUR_Coagent_ID_Qualifier { get; set; }
        public string Third_DUR_Coagent_ID { get; set; }
        public string Third_Generic_Indicator { get; set; }
        public string Third_Plan_Cutback_Reason_Code { get; set; }
        public string Third_Therapeutic_Chapter { get; set; }
        public string Third_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Third_Average_Generic_Unit_Price { get; set; }
        public string Third_Average_Wholesale_Unit_Price { get; set; }
        public string Third_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Third_MAC_Price { get; set; }
        public string Third_Basis_Of_Reimbursement_Determination { get; set; }
        public string Third_Patient_Formulary_Rebate_Amount { get; set; }
        public string Fourth_Compound_ID_Qualifier { get; set; }
        public string Fourth_Compound_ID { get; set; }
        public string Fourth_Compound_Ingredient_Quantity { get; set; }
        public string Fourth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Fourth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Fourth_Client_Formulary_Flag { get; set; }
        public string Fourth_Product_Name { get; set; }
        public string Fourth_Generic_Name { get; set; }
        public string Fourth_Product_Strength { get; set; }
        public string Fourth_Dosage_Form_Code { get; set; }
        public string Fourth_Database_Indicator { get; set; }
        public string Fourth_Drug_Type { get; set; }
        public string Fourth_Formulary_Status { get; set; }
        public string Fourth_Drug_Category_Code { get; set; }
        public string Fourth_Federal_DEA_Schedule { get; set; }
        public string Fourth_FDA_Drug_Efficacy_Code { get; set; }
        public string Fourth_Product_Code_Qualifier1 { get; set; }
        public string Fourth_Product_Code1 { get; set; }
        public string Fourth_Product_Code_Qualifier2 { get; set; }
        public string Fourth_Product_Code2 { get; set; }
        public string Fourth_Product_Code_Qualifier3 { get; set; }
        public string Fourth_Product_Code3 { get; set; }
        public string Fourth_Federal_Upper_Limit_Indicator { get; set; }
        public string Fourth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Fourth_Therapeutic_Class_Code1 { get; set; }
        public string Fourth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Fourth_Therapeutic_Class_Code2 { get; set; }
        public string Fourth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Fourth_Therapeutic_Class_Code3 { get; set; }
        public string Fourth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Fourth_Therapeutic_Class_Code4 { get; set; }
        public string Fourth_Special_Packaging_Indicator { get; set; }
        public string Fourth_Unit_Of_Measure { get; set; }
        public string Fourth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Fourth_MAC_Reduced_Indicator { get; set; }
        public string Fourth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Fourth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Fourth_DUR_Coagent_ID { get; set; }
        public string Fourth_Generic_Indicator { get; set; }
        public string Fourth_Plan_Cutback_Reason_Code { get; set; }
        public string Fourth_Therapeutic_Chapter { get; set; }
        public string Fourth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Fourth_Average_Generic_Unit_Price { get; set; }
        public string Fourth_Average_Wholesale_Unit_Price { get; set; }
        public string Fourth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Fourth_MAC_Price { get; set; }
        public string Fourth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Fourth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Fifth_Compound_ID_Qualifier { get; set; }
        public string Fifth_Compound_ID { get; set; }
        public string Fifth_Compound_Ingredient_Quantity { get; set; }
        public string Fifth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Fifth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Fifth_Client_Formulary_Flag { get; set; }
        public string Fifth_Product_Name { get; set; }
        public string Fifth_Generic_Name { get; set; }
        public string Fifth_Product_Strength { get; set; }
        public string Fifth_Dosage_Form_Code { get; set; }
        public string Fifth_Database_Indicator { get; set; }
        public string Fifth_Drug_Type { get; set; }
        public string Fifth_Formulary_Status { get; set; }
        public string Fifth_Drug_Category_Code { get; set; }
        public string Fifth_Federal_DEA_Schedule { get; set; }
        public string Fifth_FDA_Drug_Efficacy_Code { get; set; }
        public string Fifth_Product_Code_Qualifier1 { get; set; }
        public string Fifth_Product_Code1 { get; set; }
        public string Fifth_Product_Code_Qualifier2 { get; set; }
        public string Fifth_Product_Code2 { get; set; }
        public string Fifth_Product_Code_Qualifier3 { get; set; }
        public string Fifth_Product_Code3 { get; set; }
        public string Fifth_Federal_Upper_Limit_Indicator { get; set; }
        public string Fifth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Fifth_Therapeutic_Class_Code1 { get; set; }
        public string Fifth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Fifth_Therapeutic_Class_Code2 { get; set; }
        public string Fifth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Fifth_Therapeutic_Class_Code3 { get; set; }
        public string Fifth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Fifth_Therapeutic_Class_Code4 { get; set; }
        public string Fifth_Special_Packaging_Indicator { get; set; }
        public string Fifth_Unit_Of_Measure { get; set; }
        public string Fifth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Fifth_MAC_Reduced_Indicator { get; set; }
        public string Fifth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Fifth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Fifth_DUR_Coagent_ID { get; set; }
        public string Fifth_Generic_Indicator { get; set; }
        public string Fifth_Plan_Cutback_Reason_Code { get; set; }
        public string Fifth_Therapeutic_Chapter { get; set; }
        public string Fifth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Fifth_Average_Generic_Unit_Price { get; set; }
        public string Fifth_Average_Wholesale_Unit_Price { get; set; }
        public string Fifth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Fifth_MAC_Price { get; set; }
        public string Fifth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Fifth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Sixth_Compound_ID_Qualifier { get; set; }
        public string Sixth_Compound_ID { get; set; }
        public string Sixth_Compound_Ingredient_Quantity { get; set; }
        public string Sixth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Sixth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Sixth_Client_Formulary_Flag { get; set; }
        public string Sixth_Product_Name { get; set; }
        public string Sixth_Generic_Name { get; set; }
        public string Sixth_Product_Strength { get; set; }
        public string Sixth_Dosage_Form_Code { get; set; }
        public string Sixth_Database_Indicator { get; set; }
        public string Sixth_Drug_Type { get; set; }
        public string Sixth_Formulary_Status { get; set; }
        public string Sixth_Drug_Category_Code { get; set; }
        public string Sixth_Federal_DEA_Schedule { get; set; }
        public string Sixth_FDA_Drug_Efficacy_Code { get; set; }
        public string Sixth_Product_Code_Qualifier1 { get; set; }
        public string Sixth_Product_Code1 { get; set; }
        public string Sixth_Product_Code_Qualifier2 { get; set; }
        public string Sixth_Product_Code2 { get; set; }
        public string Sixth_Product_Code_Qualifier3 { get; set; }
        public string Sixth_Product_Code3 { get; set; }
        public string Sixth_Federal_Upper_Limit_Indicator { get; set; }
        public string Sixth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Sixth_Therapeutic_Class_Code1 { get; set; }
        public string Sixth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Sixth_Therapeutic_Class_Code2 { get; set; }
        public string Sixth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Sixth_Therapeutic_Class_Code3 { get; set; }
        public string Sixth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Sixth_Therapeutic_Class_Code4 { get; set; }
        public string Sixth_Special_Packaging_Indicator { get; set; }
        public string Sixth_Unit_Of_Measure { get; set; }
        public string Sixth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Sixth_MAC_Reduced_Indicator { get; set; }
        public string Sixth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Sixth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Sixth_DUR_Coagent_ID { get; set; }
        public string Sixth_Generic_Indicator { get; set; }
        public string Sixth_Plan_Cutback_Reason_Code { get; set; }
        public string Sixth_Therapeutic_Chapter { get; set; }
        public string Sixth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Sixth_Average_Generic_Unit_Price { get; set; }
        public string Sixth_Average_Wholesale_Unit_Price { get; set; }
        public string Sixth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Sixth_MAC_Price { get; set; }
        public string Sixth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Sixth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Seventh_Compound_ID_Qualifier { get; set; }
        public string Seventh_Compound_ID { get; set; }
        public string Seventh_Compound_Ingredient_Quantity { get; set; }
        public string Seventh_Compound_Ingredient_Drug_Cost { get; set; }
        public string Seventh_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Seventh_Client_Formulary_Flag { get; set; }
        public string Seventh_Product_Name { get; set; }
        public string Seventh_Generic_Name { get; set; }
        public string Seventh_Product_Strength { get; set; }
        public string Seventh_Dosage_Form_Code { get; set; }
        public string Seventh_Database_Indicator { get; set; }
        public string Seventh_Drug_Type { get; set; }
        public string Seventh_Formulary_Status { get; set; }
        public string Seventh_Drug_Category_Code { get; set; }
        public string Seventh_Federal_DEA_Schedule { get; set; }
        public string Seventh_FDA_Drug_Efficacy_Code { get; set; }
        public string Seventh_Product_Code_Qualifier1 { get; set; }
        public string Seventh_Product_Code1 { get; set; }
        public string Seventh_Product_Code_Qualifier2 { get; set; }
        public string Seventh_Product_Code2 { get; set; }
        public string Seventh_Product_Code_Qualifier3 { get; set; }
        public string Seventh_Product_Code3 { get; set; }
        public string Seventh_Federal_Upper_Limit_Indicator { get; set; }
        public string Seventh_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Seventh_Therapeutic_Class_Code1 { get; set; }
        public string Seventh_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Seventh_Therapeutic_Class_Code2 { get; set; }
        public string Seventh_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Seventh_Therapeutic_Class_Code3 { get; set; }
        public string Seventh_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Seventh_Therapeutic_Class_Code4 { get; set; }
        public string Seventh_Special_Packaging_Indicator { get; set; }
        public string Seventh_Unit_Of_Measure { get; set; }
        public string Seventh_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Seventh_MAC_Reduced_Indicator { get; set; }
        public string Seventh_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Seventh_DUR_Coagent_ID_Qualifier { get; set; }
        public string Seventh_DUR_Coagent_ID { get; set; }
        public string Seventh_Generic_Indicator { get; set; }
        public string Seventh_Plan_Cutback_Reason_Code { get; set; }
        public string Seventh_Therapeutic_Chapter { get; set; }
        public string Seventh_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Seventh_Average_Generic_Unit_Price { get; set; }
        public string Seventh_Average_Wholesale_Unit_Price { get; set; }
        public string Seventh_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Seventh_MAC_Price { get; set; }
        public string Seventh_Basis_Of_Reimbursement_Determination { get; set; }
        public string Seventh_Patient_Formulary_Rebate_Amount { get; set; }
        public string Eighth_Compound_ID_Qualifier { get; set; }
        public string Eighth_Compound_ID { get; set; }
        public string Eighth_Compound_Ingredient_Quantity { get; set; }
        public string Eighth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Eighth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Eighth_Client_Formulary_Flag { get; set; }
        public string Eighth_Product_Name { get; set; }
        public string Eighth_Generic_Name { get; set; }
        public string Eighth_Product_Strength { get; set; }
        public string Eighth_Dosage_Form_Code { get; set; }
        public string Eighth_Database_Indicator { get; set; }
        public string Eighth_Drug_Type { get; set; }
        public string Eighth_Formulary_Status { get; set; }
        public string Eighth_Drug_Category_Code { get; set; }
        public string Eighth_Federal_DEA_Schedule { get; set; }
        public string Eighth_FDA_Drug_Efficacy_Code { get; set; }
        public string Eighth_Product_Code_Qualifier1 { get; set; }
        public string Eighth_Product_Code1 { get; set; }
        public string Eighth_Product_Code_Qualifier2 { get; set; }
        public string Eighth_Product_Code2 { get; set; }
        public string Eighth_Product_Code_Qualifier3 { get; set; }
        public string Eighth_Product_Code3 { get; set; }
        public string Eighth_Federal_Upper_Limit_Indicator { get; set; }
        public string Eighth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Eighth_Therapeutic_Class_Code1 { get; set; }
        public string Eighth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Eighth_Therapeutic_Class_Code2 { get; set; }
        public string Eighth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Eighth_Therapeutic_Class_Code3 { get; set; }
        public string Eighth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Eighth_Therapeutic_Class_Code4 { get; set; }
        public string Eighth_Special_Packaging_Indicator { get; set; }
        public string Eighth_Unit_Of_Measure { get; set; }
        public string Eighth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Eighth_MAC_Reduced_Indicator { get; set; }
        public string Eighth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Eighth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Eighth_DUR_Coagent_ID { get; set; }
        public string Eighth_Generic_Indicator { get; set; }
        public string Eighth_Plan_Cutback_Reason_Code { get; set; }
        public string Eighth_Therapeutic_Chapter { get; set; }
        public string Eighth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Eighth_Average_Generic_Unit_Price { get; set; }
        public string Eighth_Average_Wholesale_Unit_Price { get; set; }
        public string Eighth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Eighth_MAC_Price { get; set; }
        public string Eighth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Eighth_Patient_Formulary_Rebate_Amount { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }

        public virtual HisDetail HisDetail { get; set; }
    }
}

