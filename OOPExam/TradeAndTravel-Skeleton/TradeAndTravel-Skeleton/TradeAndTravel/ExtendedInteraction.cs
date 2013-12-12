using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class ExtendedInteraction : InteractionManager
    {
        private bool hasWeapon;
        private bool hasArmor;
        private bool hasIron;
        private bool hasWood;
        private bool hasIronAndWood;
        private ItemType itemType;

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = base.CreatePerson(personTypeString, personNameString, personLocation);
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    break;
            }
            return person;
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    break;
            }            
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = base.CreateLocation(locationTypeString, locationName);   
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    break;
            }            
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
            }
            base.HandlePersonCommand(commandWords, actor);
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            List<Item> itemsInInventory = actor.ListInventory();
            
            if (commandWords[2] == "weapon")
            {
                itemType = ItemType.Weapon;
            }
            else if (commandWords[2] == "armor")
            {
                itemType = ItemType.Armor;
            }
            foreach (var items in itemsInInventory)
            {
                if (items.ItemType == ItemType.Iron)
                {
                    hasIron = true;
                }
                else if (items.ItemType == ItemType.Wood)
                {
                    hasWood = true;
                }
            }
            if (hasWood == true && hasIron == true)
            {
                hasIronAndWood = true;
            }
            if (itemType == ItemType.Weapon && hasIronAndWood == true)
            {
                Weapon newWeapon = new Weapon(commandWords[3], null);
                this.AddToPerson(actor, newWeapon);
            }
            if (itemType == ItemType.Armor && hasIron == true)
            {
                Armor newArmor = new Armor(commandWords[3], null);
                this.AddToPerson(actor, newArmor);
            }
            
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            List<Item> itemsInInventory = actor.ListInventory();
            foreach (var items in itemsInInventory)
            {
                if (items.ItemType == ItemType.Weapon)
                {
                    hasWeapon = true;
                }
                else if (items.ItemType == ItemType.Armor)
                {
                    hasArmor = true;
                }
            }
            if (actor.Location.LocationType == LocationType.Forest && hasWeapon == true)
            {
                Wood newWood = new Wood(commandWords[2], null);
                this.AddToPerson(actor, newWood);
            }
            else if (actor.Location.LocationType == LocationType.Mine && hasArmor == true)
            {
                Iron newIron = new Iron(commandWords[2], null);
                this.AddToPerson(actor, newIron);
            }
                

        }

    }
}
