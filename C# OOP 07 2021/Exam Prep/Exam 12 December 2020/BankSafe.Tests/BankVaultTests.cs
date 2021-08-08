using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        BankVault myVault;
        Item testItem;

        [SetUp]
        public void Setup()
        {
            myVault = new BankVault();
            testItem = new Item("Jul", "123");
        }

        [Test]
        public void Ctor_Positive()
        {
            Assert.IsNotNull(myVault.VaultCells);
        }

        [Test]
        public void AddItem_TE_When_CellDontExists()
        {
            Assert.Throws<ArgumentException>(() => myVault.AddItem("D4", testItem));
        }

        [Test]
        public void AddItem_TE_When_CellIsTaken()
        {
            myVault.AddItem("C4", testItem);
            Assert.Throws<ArgumentException>(() => myVault.AddItem("C4", testItem));
        }

        [Test]
        public void AddItem_TE_When_ItemIsAlreadyInCell()
        {
            myVault.AddItem("C4", testItem);
            Assert.Throws<InvalidOperationException>(() => myVault.AddItem("C3", testItem));
        }

        [Test]
        public void AddItem_Positive()
        {
            string result = myVault.AddItem("C4", testItem);
            Assert.That(myVault.VaultCells["C4"], Is.EqualTo(testItem));
            Assert.That(result, Is.EqualTo($"Item:{testItem.ItemId} saved successfully!"));
        }

        [Test]
        public void RemoveItem_TE_When_CellDontExists()
        {
            Assert.Throws<ArgumentException>(() => myVault.RemoveItem("D4", testItem));
        }

        [Test]
        public void RemoveItem_TE_When_ItemInThatCellDontExists()
        {
            Item testItem2 = new Item("Por", "456");
            myVault.AddItem("C1", testItem2);
            Assert.Throws<ArgumentException>(() => myVault.RemoveItem("C1", testItem));
        }

        [Test]
        public void RemoveItem_Positive()
        {
            myVault.AddItem("C4", testItem);
            string result = myVault.RemoveItem("C4", testItem);
            Assert.IsNull(myVault.VaultCells["C4"]);
            Assert.That(result, Is.EqualTo($"Remove item:{testItem.ItemId} successfully!"));
        }
    }
}