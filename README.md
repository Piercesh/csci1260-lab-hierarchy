For this lab I have chosen to make a loot system that is in a game.
There were multiple classes that had to be made for this class to work
Holding, Equipment, PlainGear, EnchantedGear, Consumable, VaultEntry, & Armory.
There were two interfaces that have been made, which are the IReportable & IDiscountable

#Holding
Holding will implement IReportable and is set as an abstract class.
What is needed are sku, name, unitPrice, quantityOnHand, history, nextSeq.
The next thing that needed to be made is a protected Holding class for Sku, Name, unitPrice, & QuantityOnHand.

#Equipment
Equipment extends Holding
Here you need the private weightPounds and then a public const HandlingRate = 0.60m
There will need to be a protected Equipment class to implement sku, name, unitPrice, quantityOnHand, & weightPounds.
There is a ShippingCost that will multiply weightPound and HandlingRate.
And the last thing you need is to override Describe to show the name, sku, weight, & Shipping.

#Enchanted Gear
EnchantedGear will extend Equipment and implement IDiscountable. 
There is a private shelfLifeDays and there is a surchargeFee that is set to 5.00m.
There is a public IsOnSale that is set to be on 30 days.
Then you need the public EnchantedGear that has sku, name, unitprice, quantityOnHands, weightPounds, & shelfLifeDays
You will need to override for Category, Handfee, & Describe.
You need the Saleprice set to decimal and then have it set to 0.90m

#PlainGear
PlainGear Extends Equipment.
In this class you will need WarrantyMonths.
Then set up public PlainGear to set up Sku, Name, unitPrice, QuantityOnHand, weightPounds, & warrantyMonths
You will need to override, Category, HandFee, & Describe.

#Consumable
Consumable Extends Holding and implements IDiscountable
LaborHours will be added to Consumable.
There is the public Consumable that has Sku, Name, unitPrice, QuantityOnHand, & LaborHours.
There is the IsOnSale that will return QuantityOnSale thats greater than 0
There is the SalePrice that will return unitPrice.
Then add override Category, HandFee, & Describe
#VaultEntry
In VaultEntry it will need Seq, Kind, & Count.
Then set up a public VaultEntry that has Seq, Kind, & Count for them to show up when the code runs.
And the last thing that is needed is a string for Describe to return seq, kind, & count.

#Armory
Armory Implements IReportable
This class will have name and a list for Holding to get items.
Then set up a public count for it to count the items.
Then set up the public Armory to get the name and set the new List<Holding>
You'll need to set up Add for the Holding item.
Then put public Holding Find for you to have the items.
Next set up a TotalValue, SaleValue, SignedCount, OnSaleCount and SortByValue.
set private static for beats (Holding a, Holding b).
Then Set up a ReportLine to show the name, item count, and TotalValue.
And the last one will be the ReportLine.

#LootDrop

#HighestValueFirst

#GroupByKey

#LootLog

#IReportable
IReportable only has one thing and that would be the string ReportLine()

#IDiscountable
IDiscountable only needs IsOnSale with {get; } and saleprice set as decimal.
Both IDiscountable and IReportable were the easy ones to put in.
