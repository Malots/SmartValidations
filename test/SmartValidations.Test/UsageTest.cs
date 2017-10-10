using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartValidations.ValueObjects;

namespace SmartValidations.Test
{
    [TestClass]
    public class UsageTest
    {
        #region CPF
        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAValidWithMaskCpfReturnTrue()
        {
            var cpf = new CPF("663.551.518-69");
            Assert.IsTrue(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAValidWithMaskCpfReturnTrueUsingValidation()
        {
            Assert.IsTrue("663.551.518-69".IsValid(Options.CPF));
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAValidWithoutMaskCpfReturnTrue()
        {
            var cpf = new CPF("66355151869");
            Assert.IsTrue(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAInvalidCpfReturnFalse()
        {
            var cpf = new CPF("123.456.789-10");
            Assert.IsFalse(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAInvalidOneNumberCpfReturnFalse()
        {
            var cpf = new CPF("111.111.111-11");
            Assert.IsFalse(cpf.IsValid());
        }
        #endregion

        #region CNPJ
        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAValidWithMaskCnpjReturnTrue()
        {
            var cnpj = new CNPJ("22.332.411/0001-17");
            Assert.IsTrue(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAValidWithMaskCnpjReturnTrueUsingValidation()
        {
            Assert.IsTrue("22.332.411/0001-17".IsValid(Options.CNPJ));
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAValidWithoutMaskCnpjReturnTrue()
        {
            var cnpj = new CNPJ("22332411000117");
            Assert.IsTrue(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAInvalidCnpjReturnFalse()
        {
            var cnpj = new CNPJ("11.111.111/1111-11");
            Assert.IsFalse(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAInvalidOneNumberCnpjReturnFalse()
        {
            var cnpj = new CNPJ("11111111111111");
            Assert.IsFalse(cnpj.IsValid());
        }
        #endregion

        #region PIS
        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAValidWithMaskPisReturnTrue()
        {
            var pis = new PIS("644.83804.32-7");
            Assert.IsTrue(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAValidWithMaskPisReturnTrueUsingValidation()
        {
            Assert.IsTrue("644.83804.32-7".IsValid(Options.PIS));
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAValidWithoutMaskPisReturnTrue()
        {
            var pis = new PIS("64483804327");
            Assert.IsTrue(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAInvalidPisReturnFalse()
        {
            var pis = new PIS("111.11111.11-1");
            Assert.IsFalse(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAInvalidOneNumberPisReturnFalse()
        {
            var pis = new PIS("11111111111");
            Assert.IsFalse(pis.IsValid());
        }
        #endregion

        #region Email
        [TestMethod]
        [TestCategory("Email")]
        public void GiveAValidEmailReturnTrue()
        {
            var email = new Email("email@email.com");
            Assert.IsTrue(email.IsValid());
        }

        [TestMethod]
        [TestCategory("Email")]
        public void GiveAValidEmailReturnTrueUsingValidation()
        {
            Assert.IsTrue("email@email.com".IsValid(Options.Email));
        }

        [TestMethod]
        [TestCategory("Email")]
        public void GiveAInvalidEmailReturnFalse()
        {
            var email = new Email("email&%@email.com");
            Assert.IsFalse(email.IsValid());
        }
        #endregion

        #region CNH
        [TestMethod]
        [TestCategory("CNH")]
        public void GiveAValidCnhReturnTrue()
        {
            var cnh = new CNH("56551780945");
            Assert.IsTrue(cnh.IsValid());
        }

        [TestMethod]
        [TestCategory("CNH")]
        public void GiveAValidCnhReturnTrueUsingValidations()
        {
            Assert.IsTrue("56551780945".IsValid(Options.CNH));
        }

        [TestMethod]
        [TestCategory("CNH")]
        public void GiveAInvalidCnhReturnFalse()
        {
            var cnh = new CNH("12345678912");
            Assert.IsFalse(cnh.IsValid());
        }
        #endregion

        #region Credit Card
        [TestMethod]
        [TestCategory("Credit Card")]
        public void GiveAValidCreditCardNumberReturnTrue()
        {
            var card = new CreditCard("4799564602300008");
            Assert.IsTrue(card.IsValid());
        }

        [TestMethod]
        [TestCategory("Credit Card")]
        public void GiveAValidCreditCardNumberReturnTrueUsingValidation()
        {
            Assert.IsTrue("4799564602300008".IsValid(Options.CreditCard));
        }

        [TestMethod]
        [TestCategory("Credit Card")]
        public void GiveAInvalidCreditCardNumberReturnFalse()
        {
            var card = new CreditCard("1234567894512");
            Assert.IsFalse(card.IsValid());
        }
        #endregion

        #region UF
        [TestMethod]
        [TestCategory("UF")]
        public void GiveAValidUFReturnTrue()
        {
            var uf = new UF("SP");
            Assert.IsTrue(uf.IsValid());
        }

        [TestMethod]
        [TestCategory("UF")]
        public void GiveAValidUFReturnTrueUsingValidation()
        {
            Assert.IsTrue("SP".IsValid(Options.UF));
        }

        [TestMethod]
        [TestCategory("UF")]
        public void GiveAInvalidUFReturnFalse()
        {
            var uf = new UF("ABSP");
            Assert.IsFalse(uf.IsValid());
        }
        #endregion

        #region CEP
        [TestMethod]
        [TestCategory("CEP")]
        public void GiveAValidCepReturnTrue()
        {
            var cep = new CEP("19026-570","SP");
            Assert.IsTrue(cep.IsValid());
        }

        [TestMethod]
        [TestCategory("CEP")]
        public void GiveAValidCepReturnTrueUsingValidation()
        {
            Assert.IsTrue("19026-570".IsValid(Options.CEP));
        }

        [TestMethod]
        [TestCategory("CEP")]
        public void GiveAInvalidCepReturnFalse()
        {
            var cep = new CEP("19026-570", "PR");
            Assert.IsFalse(cep.IsValid());
        }
        #endregion
    }
}
