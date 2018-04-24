﻿namespace PAHWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PharmCD2
    {
        [Key]
        public int Compound2ID { get; set; }
        [Required]
        public int DetailID { get; set; }
        public string RecordType { get; set; }
        public string Prescription_Reference_Number_Qualifier { get; set; }
        public string Prescription_Reference_Number { get; set; }
        public string Compound_Ingredient_Component_Count { get; set; }
        public string Ninth_Compound_ID_Qualifier { get; set; }
        public string Ninth_Compound_ID { get; set; }
        public string Ninth_Compound_Ingredient_Quantity { get; set; }
        public string Ninth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Ninth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Ninth_Client_Formulary_Flag { get; set; }
        public string Ninth_Product_Name { get; set; }
        public string Ninth_Generic_Name { get; set; }
        public string Ninth_Product_Strength { get; set; }
        public string Ninth_Dosage_Form_Code { get; set; }
        public string Ninth_Database_Indicator { get; set; }
        public string Ninth_Drug_Type { get; set; }
        public string Ninth_Formulary_Status { get; set; }
        public string Ninth_Drug_Category_Code { get; set; }
        public string Ninth_Federal_DEA_Schedule { get; set; }
        public string Ninth_FDA_Drug_Efficacy_Code { get; set; }
        public string Ninth_Product_Code_Qualifier1 { get; set; }
        public string Ninth_Product_Code1 { get; set; }
        public string Ninth_Product_Code_Qualifier2 { get; set; }
        public string Ninth_Product_Code2 { get; set; }
        public string Ninth_Product_Code_Qualifier3 { get; set; }
        public string Ninth_Product_Code3 { get; set; }
        public string Ninth_Federal_Upper_Limit_Indicator { get; set; }
        public string Ninth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Ninth_Therapeutic_Class_Code1 { get; set; }
        public string Ninth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Ninth_Therapeutic_Class_Code2 { get; set; }
        public string Ninth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Ninth_Therapeutic_Class_Code3 { get; set; }
        public string Ninth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Ninth_Therapeutic_Class_Code4 { get; set; }
        public string Ninth_Special_Packaging_Indicator { get; set; }
        public string Ninth_Unit_Of_Measure { get; set; }
        public string Ninth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Ninth_MAC_Reduced_Indicator { get; set; }
        public string Ninth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Ninth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Ninth_DUR_Coagent_ID { get; set; }
        public string Ninth_Generic_Indicator { get; set; }
        public string Ninth_Plan_Cutback_Reason_Code { get; set; }
        public string Ninth_Therapeutic_Chapter { get; set; }
        public string Ninth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Ninth_Average_Generic_Unit_Price { get; set; }
        public string Ninth_Average_Wholesale_Unit_Price { get; set; }
        public string Ninth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Ninth_MAC_Price { get; set; }
        public string Ninth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Ninth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Tenth_Compound_ID_Qualifier { get; set; }
        public string Tenth_Compound_ID { get; set; }
        public string Tenth_Compound_Ingredient_Quantity { get; set; }
        public string Tenth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Tenth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Tenth_Client_Formulary_Flag { get; set; }
        public string Tenth_Product_Name { get; set; }
        public string Tenth_Generic_Name { get; set; }
        public string Tenth_Product_Strength { get; set; }
        public string Tenth_Dosage_Form_Code { get; set; }
        public string Tenth_Database_Indicator { get; set; }
        public string Tenth_Drug_Type { get; set; }
        public string Tenth_Formulary_Status { get; set; }
        public string Tenth_Drug_Category_Code { get; set; }
        public string Tenth_Federal_DEA_Schedule { get; set; }
        public string Tenth_FDA_Drug_Efficacy_Code { get; set; }
        public string Tenth_Product_Code_Qualifier1 { get; set; }
        public string Tenth_Product_Code1 { get; set; }
        public string Tenth_Product_Code_Qualifier2 { get; set; }
        public string Tenth_Product_Code2 { get; set; }
        public string Tenth_Product_Code_Qualifier3 { get; set; }
        public string Tenth_Product_Code3 { get; set; }
        public string Tenth_Federal_Upper_Limit_Indicator { get; set; }
        public string Tenth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Tenth_Therapeutic_Class_Code1 { get; set; }
        public string Tenth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Tenth_Therapeutic_Class_Code2 { get; set; }
        public string Tenth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Tenth_Therapeutic_Class_Code3 { get; set; }
        public string Tenth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Tenth_Therapeutic_Class_Code4 { get; set; }
        public string Tenth_Special_Packaging_Indicator { get; set; }
        public string Tenth_Unit_Of_Measure { get; set; }
        public string Tenth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Tenth_MAC_Reduced_Indicator { get; set; }
        public string Tenth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Tenth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Tenth_DUR_Coagent_ID { get; set; }
        public string Tenth_Generic_Indicator { get; set; }
        public string Tenth_Plan_Cutback_Reason_Code { get; set; }
        public string Tenth_Therapeutic_Chapter { get; set; }
        public string Tenth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Tenth_Average_Generic_Unit_Price { get; set; }
        public string Tenth_Average_Wholesale_Unit_Price { get; set; }
        public string Tenth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Tenth_MAC_Price { get; set; }
        public string Tenth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Tenth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Eleventh_Compound_ID_Qualifier { get; set; }
        public string Eleventh_Compound_ID { get; set; }
        public string Eleventh_Compound_Ingredient_Quantity { get; set; }
        public string Eleventh_Compound_Ingredient_Drug_Cost { get; set; }
        public string Eleventh_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Eleventh_Client_Formulary_Flag { get; set; }
        public string Eleventh_Product_Name { get; set; }
        public string Eleventh_Generic_Name { get; set; }
        public string Eleventh_Product_Strength { get; set; }
        public string Eleventh_Dosage_Form_Code { get; set; }
        public string Eleventh_Database_Indicator { get; set; }
        public string Eleventh_Drug_Type { get; set; }
        public string Eleventh_Formulary_Status { get; set; }
        public string Eleventh_Drug_Category_Code { get; set; }
        public string Eleventh_Federal_DEA_Schedule { get; set; }
        public string Eleventh_FDA_Drug_Efficacy_Code { get; set; }
        public string Eleventh_Product_Code_Qualifier1 { get; set; }
        public string Eleventh_Product_Code1 { get; set; }
        public string Eleventh_Product_Code_Qualifier2 { get; set; }
        public string Eleventh_Product_Code2 { get; set; }
        public string Eleventh_Product_Code_Qualifier3 { get; set; }
        public string Eleventh_Product_Code3 { get; set; }
        public string Eleventh_Federal_Upper_Limit_Indicator { get; set; }
        public string Eleventh_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Eleventh_Therapeutic_Class_Code1 { get; set; }
        public string Eleventh_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Eleventh_Therapeutic_Class_Code2 { get; set; }
        public string Eleventh_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Eleventh_Therapeutic_Class_Code3 { get; set; }
        public string Eleventh_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Eleventh_Therapeutic_Class_Code4 { get; set; }
        public string Eleventh_Special_Packaging_Indicator { get; set; }
        public string Eleventh_Unit_Of_Measure { get; set; }
        public string Eleventh_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Eleventh_MAC_Reduced_Indicator { get; set; }
        public string Eleventh_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Eleventh_DUR_Coagent_ID_Qualifier { get; set; }
        public string Eleventh_DUR_Coagent_ID { get; set; }
        public string Eleventh_Generic_Indicator { get; set; }
        public string Eleventh_Plan_Cutback_Reason_Code { get; set; }
        public string Eleventh_Therapeutic_Chapter { get; set; }
        public string Eleventh_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Eleventh_Average_Generic_Unit_Price { get; set; }
        public string Eleventh_Average_Wholesale_Unit_Price { get; set; }
        public string Eleventh_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Eleventh_MAC_Price { get; set; }
        public string Eleventh_Basis_Of_Reimbursement_Determination { get; set; }
        public string Eleventh_Patient_Formulary_Rebate_Amount { get; set; }
        public string Twelfth_Compound_ID_Qualifier { get; set; }
        public string Twelfth_Compound_ID { get; set; }
        public string Twelfth_Compound_Ingredient_Quantity { get; set; }
        public string Twelfth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Twelfth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Twelfth_Client_Formulary_Flag { get; set; }
        public string Twelfth_Product_Name { get; set; }
        public string Twelfth_Generic_Name { get; set; }
        public string Twelfth_Product_Strength { get; set; }
        public string Twelfth_Dosage_Form_Code { get; set; }
        public string Twelfth_Database_Indicator { get; set; }
        public string Twelfth_Drug_Type { get; set; }
        public string Twelfth_Formulary_Status { get; set; }
        public string Twelfth_Drug_Category_Code { get; set; }
        public string Twelfth_Federal_DEA_Schedule { get; set; }
        public string Twelfth_FDA_Drug_Efficacy_Code { get; set; }
        public string Twelfth_Product_Code_Qualifier1 { get; set; }
        public string Twelfth_Product_Code1 { get; set; }
        public string Twelfth_Product_Code_Qualifier2 { get; set; }
        public string Twelfth_Product_Code2 { get; set; }
        public string Twelfth_Product_Code_Qualifier3 { get; set; }
        public string Twelfth_Product_Code3 { get; set; }
        public string Twelfth_Federal_Upper_Limit_Indicator { get; set; }
        public string Twelfth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Twelfth_Therapeutic_Class_Code1 { get; set; }
        public string Twelfth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Twelfth_Therapeutic_Class_Code2 { get; set; }
        public string Twelfth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Twelfth_Therapeutic_Class_Code3 { get; set; }
        public string Twelfth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Twelfth_Therapeutic_Class_Code4 { get; set; }
        public string Twelfth_Special_Packaging_Indicator { get; set; }
        public string Twelfth_Unit_Of_Measure { get; set; }
        public string Twelfth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Twelfth_MAC_Reduced_Indicator { get; set; }
        public string Twelfth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Twelfth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Twelfth_DUR_Coagent_ID { get; set; }
        public string Twelfth_Generic_Indicator { get; set; }
        public string Twelfth_Plan_Cutback_Reason_Code { get; set; }
        public string Twelfth_Therapeutic_Chapter { get; set; }
        public string Twelfth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Twelfth_Average_Generic_Unit_Price { get; set; }
        public string Twelfth_Average_Wholesale_Unit_Price { get; set; }
        public string Twelfth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Twelfth_MAC_Price { get; set; }
        public string Twelfth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Twelfth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Thirteenth_Compound_ID_Qualifier { get; set; }
        public string Thirteenth_Compound_ID { get; set; }
        public string Thirteenth_Compound_Ingredient_Quantity { get; set; }
        public string Thirteenth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Thirteenth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Thirteenth_Client_Formulary_Flag { get; set; }
        public string Thirteenth_Product_Name { get; set; }
        public string Thirteenth_Generic_Name { get; set; }
        public string Thirteenth_Product_Strength { get; set; }
        public string Thirteenth_Dosage_Form_Code { get; set; }
        public string Thirteenth_Database_Indicator { get; set; }
        public string Thirteenth_Drug_Type { get; set; }
        public string Thirteenth_Formulary_Status { get; set; }
        public string Thirteenth_Drug_Category_Code { get; set; }
        public string Thirteenth_Federal_DEA_Schedule { get; set; }
        public string Thirteenth_FDA_Drug_Efficacy_Code { get; set; }
        public string Thirteenth_Product_Code_Qualifier1 { get; set; }
        public string Thirteenth_Product_Code1 { get; set; }
        public string Thirteenth_Product_Code_Qualifier2 { get; set; }
        public string Thirteenth_Product_Code2 { get; set; }
        public string Thirteenth_Product_Code_Qualifier3 { get; set; }
        public string Thirteenth_Product_Code3 { get; set; }
        public string Thirteenth_Federal_Upper_Limit_Indicator { get; set; }
        public string Thirteenth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code1 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code2 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code3 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Thirteenth_Therapeutic_Class_Code4 { get; set; }
        public string Thirteenth_Special_Packaging_Indicator { get; set; }
        public string Thirteenth_Unit_Of_Measure { get; set; }
        public string Thirteenth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Thirteenth_MAC_Reduced_Indicator { get; set; }
        public string Thirteenth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Thirteenth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Thirteenth_DUR_Coagent_ID { get; set; }
        public string Thirteenth_Generic_Indicator { get; set; }
        public string Thirteenth_Plan_Cutback_Reason_Code { get; set; }
        public string Thirteenth_Therapeutic_Chapter { get; set; }
        public string Thirteenth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Thirteenth_Average_Generic_Unit_Price { get; set; }
        public string Thirteenth_Average_Wholesale_Unit_Price { get; set; }
        public string Thirteenth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Thirteenth_MAC_Price { get; set; }
        public string Thirteenth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Thirteenth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Fourteenth_Compound_ID_Qualifier { get; set; }
        public string Fourteenth_Compound_ID { get; set; }
        public string Fourteenth_Compound_Ingredient_Quantity { get; set; }
        public string Fourteenth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Fourteenth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Fourteenth_Client_Formulary_Flag { get; set; }
        public string Fourteenth_Product_Name { get; set; }
        public string Fourteenth_Generic_Name { get; set; }
        public string Fourteenth_Product_Strength { get; set; }
        public string Fourteenth_Dosage_Form_Code { get; set; }
        public string Fourteenth_Database_Indicator { get; set; }
        public string Fourteenth_Drug_Type { get; set; }
        public string Fourteenth_Formulary_Status { get; set; }
        public string Fourteenth_Drug_Category_Code { get; set; }
        public string Fourteenth_Federal_DEA_Schedule { get; set; }
        public string Fourteenth_FDA_Drug_Efficacy_Code { get; set; }
        public string Fourteenth_Product_Code_Qualifier1 { get; set; }
        public string Fourteenth_Product_Code1 { get; set; }
        public string Fourteenth_Product_Code_Qualifier2 { get; set; }
        public string Fourteenth_Product_Code2 { get; set; }
        public string Fourteenth_Product_Code_Qualifier3 { get; set; }
        public string Fourteenth_Product_Code3 { get; set; }
        public string Fourteenth_Federal_Upper_Limit_Indicator { get; set; }
        public string Fourteenth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code1 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code2 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code3 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Fourteenth_Therapeutic_Class_Code4 { get; set; }
        public string Fourteenth_Special_Packaging_Indicator { get; set; }
        public string Fourteenth_Unit_Of_Measure { get; set; }
        public string Fourteenth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Fourteenth_MAC_Reduced_Indicator { get; set; }
        public string Fourteenth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Fourteenth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Fourteenth_DUR_Coagent_ID { get; set; }
        public string Fourteenth_Generic_Indicator { get; set; }
        public string Fourteenth_Plan_Cutback_Reason_Code { get; set; }
        public string Fourteenth_Therapeutic_Chapter { get; set; }
        public string Fourteenth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Fourteenth_Average_Generic_Unit_Price { get; set; }
        public string Fourteenth_Average_Wholesale_Unit_Price { get; set; }
        public string Fourteenth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Fourteenth_MAC_Price { get; set; }
        public string Fourteenth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Fourteenth_Patient_Formulary_Rebate_Amount { get; set; }
        public string Fifteenth_Compound_ID_Qualifier { get; set; }
        public string Fifteenth_Compound_ID { get; set; }
        public string Fifteenth_Compound_Ingredient_Quantity { get; set; }
        public string Fifteenth_Compound_Ingredient_Drug_Cost { get; set; }
        public string Fifteenth_Compound_ingredient_Basis_Of_Cost_Determination { get; set; }
        public string Fifteenth_Client_Formulary_Flag { get; set; }
        public string Fifteenth_Product_Name { get; set; }
        public string Fifteenth_Generic_Name { get; set; }
        public string Fifteenth_Product_Strength { get; set; }
        public string Fifteenth_Dosage_Form_Code { get; set; }
        public string Fifteenth_Database_Indicator { get; set; }
        public string Fifteenth_Drug_Type { get; set; }
        public string Fifteenth_Formulary_Status { get; set; }
        public string Fifteenth_Drug_Category_Code { get; set; }
        public string Fifteenth_Federal_DEA_Schedule { get; set; }
        public string Fifteenth_FDA_Drug_Efficacy_Code { get; set; }
        public string Fifteenth_Product_Code_Qualifier1 { get; set; }
        public string Fifteenth_Product_Code1 { get; set; }
        public string Fifteenth_Product_Code_Qualifier2 { get; set; }
        public string Fifteenth_Product_Code2 { get; set; }
        public string Fifteenth_Product_Code_Qualifier3 { get; set; }
        public string Fifteenth_Product_Code3 { get; set; }
        public string Fifteenth_Federal_Upper_Limit_Indicator { get; set; }
        public string Fifteenth_Therapeutic_Class_Code_Qualifier1 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code1 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code_Qualifier2 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code2 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code_Qualifier3 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code3 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code_Qualifier4 { get; set; }
        public string Fifteenth_Therapeutic_Class_Code4 { get; set; }
        public string Fifteenth_Special_Packaging_Indicator { get; set; }
        public string Fifteenth_Unit_Of_Measure { get; set; }
        public string Fifteenth_Processor_Defined_Prior_Authorization_Reason_Code { get; set; }
        public string Fifteenth_MAC_Reduced_Indicator { get; set; }
        public string Fifteenth_Client_Pricing_Basis_Of_Cost { get; set; }
        public string Fifteenth_DUR_Coagent_ID_Qualifier { get; set; }
        public string Fifteenth_DUR_Coagent_ID { get; set; }
        public string Fifteenth_Generic_Indicator { get; set; }
        public string Fifteenth_Plan_Cutback_Reason_Code { get; set; }
        public string Fifteenth_Therapeutic_Chapter { get; set; }
        public string Fifteenth_Average_Cost_Per_Quantity_Unit_Price { get; set; }
        public string Fifteenth_Average_Generic_Unit_Price { get; set; }
        public string Fifteenth_Average_Wholesale_Unit_Price { get; set; }
        public string Fifteenth_Federal_Upper_Limit_Unit_Price { get; set; }
        public string Fifteenth_MAC_Price { get; set; }
        public string Fifteenth_Basis_Of_Reimbursement_Determination { get; set; }
        public string Fifteenth_Patient_Formulary_Rebate_Amount { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }

        public virtual PharmDE PharmDE { get; set; }
    }
}

