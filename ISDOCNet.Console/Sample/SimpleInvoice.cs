using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISDOCNet.Console.Sample
{
    public class SimpleInvoiceVat
    {
        public static Invoice Create()
        {
            var customerName = "Zákazník";
            var customerICO = "123456789";
            var customerContact = new Contact(customerName, "+420 605 123 456", "zakaznik@faktura.cz");
            var customerAddress = new PostalAddress(Country.CzechRepulic(), "Ostrava", "Nádražní", "17", "702 00");
            var supplierName = "Dodavatel";
            var supplierICO = "987654321";
            var supplierDIC = "CZ987654321";
            var supplierRegisterInformation = "Zaregistrováno u Soudu AAA";
            var supplierContact = new Contact(supplierName, "+420 605 123 456", "dodavatel@faktura.cz");
            var supplierAddress = new PostalAddress(Country.CzechRepulic(), "Praha", "Dvořákova", "13", "105 00");

            var result = new ISDOCNet.Invoice();
            result.version = "6.0.1";
            result.LocalCurrencyCode = "CZK";
            result.CurrRate = 1;
            result.ID = "20200001"; //Invoice Number
            result.UUID = Guid.NewGuid().ToString(); // Unique inovice identification
            result.IssueDate = DateTime.Now;
            result.TaxPointDate = DateTime.Now;
            result.VATApplicable = true; //With VAT
            result.RefCurrRate = 1; // CZK To CZK
            result.ElectronicPossibilityAgreementReference = new Note();
            result.BuyerCustomerParty = new BuyerCustomerParty();
            result.BuyerCustomerParty.Party = new Party();
            result.BuyerCustomerParty.Party.Contact = customerContact;
            result.BuyerCustomerParty.Party.PartyIdentification = new PartyIdentification("Zákazník 1", "", customerICO);
            result.BuyerCustomerParty.Party.PartyName = new PartyName(customerName);
            result.BuyerCustomerParty.Party.PostalAddress = customerAddress;
            result.AccountingCustomerParty = new AccountingCustomerParty();
            result.AccountingCustomerParty.Party = new Party();
            result.AccountingCustomerParty.Party.Contact = customerContact;
            result.AccountingCustomerParty.Party.PartyIdentification = new PartyIdentification("Zákazník 1", "", customerICO);
            result.AccountingCustomerParty.Party.PartyName = new PartyName(customerName);
            result.AccountingCustomerParty.Party.PostalAddress = customerAddress;
            result.SellerSupplierParty = new SellerSupplierParty();
            result.SellerSupplierParty.Party = new Party();
            result.SellerSupplierParty.Party.Contact = supplierContact;
            result.SellerSupplierParty.Party.PartyIdentification = new PartyIdentification("Dodavatel 1", "", supplierICO);
            result.SellerSupplierParty.Party.PartyName = new PartyName(supplierName);
            result.SellerSupplierParty.Party.PostalAddress = supplierAddress;
            result.SellerSupplierParty.Party.PartyTaxScheme = new PartyTaxScheme();
            result.SellerSupplierParty.Party.PartyTaxScheme.CompanyID = supplierDIC;
            result.SellerSupplierParty.Party.PartyTaxScheme.TaxScheme = "VAT";
            result.SellerSupplierParty.Party.RegisterIdentification = new RegisterIdentification(supplierRegisterInformation);
            result.AccountingSupplierParty = new AccountingSupplierParty();
            result.AccountingSupplierParty.Party = new Party();
            result.AccountingSupplierParty.Party.Contact = supplierContact;
            result.AccountingSupplierParty.Party.PartyIdentification = new PartyIdentification("Dodavatel 1", "", supplierICO);
            result.AccountingSupplierParty.Party.PartyName = new PartyName(supplierName);
            result.AccountingSupplierParty.Party.PostalAddress = supplierAddress;
            result.AccountingSupplierParty.Party.PartyTaxScheme = new PartyTaxScheme();
            result.AccountingSupplierParty.Party.PartyTaxScheme.CompanyID = supplierDIC;
            result.AccountingSupplierParty.Party.PartyTaxScheme.TaxScheme = "VAT";
            result.AccountingSupplierParty.Party.RegisterIdentification = new RegisterIdentification(supplierRegisterInformation);
            var i = 1;

            //foreach (var item in invoice.InvoiceItems)
            //{
            //    var line = new InvoiceLine();
            //    line.ClassifiedTaxCategory = new ClassifiedTaxCategory();
            //    line.ClassifiedTaxCategory.Percent = item.TaxVat.Value;
            //    line.ClassifiedTaxCategory.VATApplicable = item.TaxVat.Value >= 0;
            //    line.ClassifiedTaxCategory.VATCalculationMethod = VATCalculationMethod.Item0;
            //    line.ID = i.ToString();
            //    line.InvoicedQuantity = new Quantity(item.UnitType.Code, item.Quantity);
            //    line.Item = new Item();
            //    line.Item.Description = item.Name;
            //    line.UnitPrice = item.Price;
            //    line.UnitPriceTaxInclusive = item.PriceVAT;
            //    line.LineExtensionAmount = item.Price;
            //    line.LineExtensionAmountTaxInclusive = item.PriceVAT;
            //    line.LineExtensionTaxAmount = item.PriceVAT - item.Price;

            //    if (result.InvoiceLines == null)
            //        result.InvoiceLines = new List<InvoiceLine>();
            //    result.InvoiceLines.Add(line);
            //    i++;
            //}

            var line = new InvoiceLine();
            line.ClassifiedTaxCategory = new ClassifiedTaxCategory();
            line.ClassifiedTaxCategory.Percent = 21; //VAT
            line.ClassifiedTaxCategory.VATApplicable = true;
            line.ClassifiedTaxCategory.VATCalculationMethod = VATCalculationMethod.Item0;
            line.ID = i.ToString();
            line.InvoicedQuantity = new Quantity("KS", 1);
            line.Item = new Item();
            line.Item.Description = "Product";
            line.UnitPrice = 100;
            line.UnitPriceTaxInclusive = 121;
            line.LineExtensionAmount = 100;
            line.LineExtensionAmountTaxInclusive = 121;
            line.LineExtensionTaxAmount = 21;

            if (result.InvoiceLines == null)
                result.InvoiceLines = new List<InvoiceLine>();
            result.InvoiceLines.Add(line);
            i++;

            result.TaxTotal = new TaxTotal();
            result.TaxTotal.TaxAmount = 0;
            result.TaxTotal.TaxSubTotal = new List<TaxSubTotal>();
            foreach (var taxGroup in result.InvoiceLines.GroupBy(p => p.ClassifiedTaxCategory.Percent)) 
            {
                var taxSubTotal = new TaxSubTotal();
                taxSubTotal.TaxableAmount = taxGroup.Sum(p => p.LineExtensionAmount);
                taxSubTotal.TaxInclusiveAmount = taxGroup.Sum(p => p.LineExtensionAmountTaxInclusive);
                taxSubTotal.TaxAmount = taxSubTotal.TaxInclusiveAmount - taxSubTotal.TaxableAmount;
                if (taxGroup.Key.Value > 0)
                {
                    taxSubTotal.TaxCategory = new TaxCategory();
                    taxSubTotal.TaxCategory.VATApplicable = true;
                    taxSubTotal.TaxCategory.Percent = taxGroup.Key.Value;
                }
                else
                {
                    taxSubTotal.TaxCategory = new TaxCategory();
                    taxSubTotal.TaxCategory.VATApplicable = false;
                    taxSubTotal.TaxCategory.Percent = 0;
                }

                taxSubTotal.AlreadyClaimedTaxableAmount = 0;
                taxSubTotal.AlreadyClaimedTaxAmount = 0;
                taxSubTotal.AlreadyClaimedTaxInclusiveAmount = 0;
                taxSubTotal.DifferenceTaxableAmount = taxSubTotal.TaxableAmount - taxSubTotal.AlreadyClaimedTaxableAmount;
                taxSubTotal.DifferenceTaxAmount = taxSubTotal.TaxAmount - taxSubTotal.AlreadyClaimedTaxAmount;
                taxSubTotal.DifferenceTaxInclusiveAmount = taxSubTotal.TaxInclusiveAmount - taxSubTotal.AlreadyClaimedTaxInclusiveAmount;
                result.TaxTotal.TaxSubTotal.Add(taxSubTotal);
            }

            result.LegalMonetaryTotal = new LegalMonetaryTotal();
            result.LegalMonetaryTotal.TaxExclusiveAmount = result.InvoiceLines.Sum(p => p.LineExtensionAmount);
            result.LegalMonetaryTotal.TaxInclusiveAmount = result.InvoiceLines.Sum(p => p.LineExtensionAmountTaxInclusive);
            result.LegalMonetaryTotal.AlreadyClaimedTaxExclusiveAmount = 0;
            result.LegalMonetaryTotal.AlreadyClaimedTaxInclusiveAmount = 0;
            result.LegalMonetaryTotal.DifferenceTaxExclusiveAmount = result.LegalMonetaryTotal.TaxExclusiveAmount - result.LegalMonetaryTotal.AlreadyClaimedTaxExclusiveAmount;
            result.LegalMonetaryTotal.DifferenceTaxInclusiveAmount = result.LegalMonetaryTotal.TaxInclusiveAmount - result.LegalMonetaryTotal.AlreadyClaimedTaxInclusiveAmount;
            result.LegalMonetaryTotal.PayableRoundingAmount = 0;
            result.LegalMonetaryTotal.PaidDepositsAmount = 0;
            result.LegalMonetaryTotal.PayableAmount = result.LegalMonetaryTotal.TaxInclusiveAmount - result.LegalMonetaryTotal.PaidDepositsAmount;
            return result;
        }
    }
}
