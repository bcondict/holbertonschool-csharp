using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_BaseId()
        {
            BaseClass a = new BaseClass();
            BaseClass b = new BaseClass();

            Assert.AreNotEqual(a.id, b.id);
        }

        [Test]
        public void Test_BaseDateTime()
        {
            BaseClass b = new BaseClass();

            Assert.AreNotEqual(b.date_created, b.date_updated);
            Assert.IsNotNull(b.date_created);
            Assert.IsNotNull(b.date_updated);
        }

        [Test]
        public void Test_ItemName()
        {
            Item i = new Item("Item Name");

            Assert.AreEqual(i.name, "Item Name");
            Assert.IsNotNull(i.name);
            Assert.IsNull(i.description);
            Assert.IsNull(i.tags);
        }

        [Test]
        public void Test_ItemDescription()
        {
            Item i = new Item("Item Thing", "Item Description");

            Assert.AreEqual(i.description, "Item Description");
            Assert.IsNotNull(i.description);
            Assert.IsNull(i.tags);
        }

        [Test]
        public void Test_ItemPrice()
        {
            Item i = new Item("Item Thing", "Item Description", 5.00f);

            Assert.AreEqual(i.price, 5.00);
        }

        [Test]
        public void Test_UserName()
        {
            User u = new User("User Name");

            Assert.AreEqual(u.name, "User Name");
        }

        [Test]
        public void Test_InventoryUserId()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 1);

            Assert.AreEqual(inventory.user_id, "User ID");
            Assert.AreNotEqual(inventory.user_id, "Item ID");
        }

        [Test]
        public void Test_InventoryItemId()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 1);

            Assert.AreEqual(inventory.item_id, "Item ID");
            Assert.AreNotEqual(inventory.item_id, "User ID");
        }

        [Test]
        public void Test_InventoryQuantityPos()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 1);

            Assert.AreEqual(inventory.quantity, 1);
            Assert.AreNotEqual(inventory.item_id, inventory.user_id);
        }

        [Test]
        public void Test_InventoryQuantityZero()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 0);

            Assert.AreEqual(inventory.quantity, 1);
            Assert.AreNotEqual(inventory.quantity, 0);
        }

        [Test]
        public void Test_InventoryQuantityNeg()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", -1);

            Assert.AreEqual(inventory.quantity, 1);
            Assert.AreNotEqual(inventory.quantity, -1);
        }

        [Test]
        public void Test_JSONStorage()
        {
            JSONStorage storage= new JSONStorage();
            Dictionary<string, object> example = new Dictionary<string, object>();

            Assert.AreEqual(storage.objects, example);
        }
    }
}
