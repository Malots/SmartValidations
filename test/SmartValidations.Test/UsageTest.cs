using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartValidations.ValueObjects;

namespace SmartValidations.Test
{
    [TestClass]
    public class UsageTest
    {
        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAValidWithMaskCpfReturnTrue()
        {
            CPF cpf = new CPF("663.551.518-69");
            Assert.IsTrue(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAValidWithoutMaskCpfReturnTrue()
        {
            CPF cpf = new CPF("66355151869");
            Assert.IsTrue(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAInvalidCpfReturnFalse()
        {
            CPF cpf = new CPF("123.456.789-10");
            Assert.IsFalse(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CPF")]
        public void GiveAInvalidOneNumberCpfReturnFalse()
        {
            CPF cpf = new CPF("111.111.111-11");
            Assert.IsFalse(cpf.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAValidWithMaskCnpjReturnTrue()
        {
            CNPJ cnpj = new CNPJ("22.332.411/0001-17");
            Assert.IsTrue(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAValidWithoutMaskCnpjReturnTrue()
        {
            CNPJ cnpj = new CNPJ("22332411000117");
            Assert.IsTrue(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAInvalidCnpjReturnFalse()
        {
            CNPJ cnpj = new CNPJ("11.111.111/1111-11");
            Assert.IsFalse(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("CNPJ")]
        public void GiveAInvalidOneNumberCnpjReturnFalse()
        {
            CNPJ cnpj = new CNPJ("11111111111111");
            Assert.IsFalse(cnpj.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAValidWithMaskPisReturnTrue()
        {
            PIS pis = new PIS("644.83804.32-7");
            Assert.IsTrue(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAValidWithoutMaskPisReturnTrue()
        {
            PIS pis = new PIS("64483804327");
            Assert.IsTrue(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAInvalidPisReturnFalse()
        {
            PIS pis = new PIS("111.11111.11-1");
            Assert.IsFalse(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("PIS")]
        public void GiveAInvalidOneNumberPisReturnFalse()
        {
            PIS pis = new PIS("11111111111");
            Assert.IsFalse(pis.IsValid());
        }

        [TestMethod]
        [TestCategory("Email")]
        public void GiveAValidEmailReturnTrue()
        {
            Email email = new Email("email@email.com");
            Assert.IsTrue(email.IsValid());
        }

        [TestMethod]
        [TestCategory("Email")]
        public void GiveAInvalidEmailReturnFalse()
        {
            Email email = new Email("email&%@email.com");
            Assert.IsFalse(email.IsValid());
        }

        [TestMethod]
        [TestCategory("CNH")]
        public void GiveAValidCnhReturnTrue()
        {
            CNH cnh = new CNH("56551780945");
            Assert.IsTrue(cnh.IsValid());
        }
    }
}
