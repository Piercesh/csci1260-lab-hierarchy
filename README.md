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
Armory might be the longest one I had to work as to make sure everything was set up correctly and make sure it matched up as to what
I was going for.

#Starting on lab 3 this one did take me a few days, but it wasn't too long as lab 2. I had go and figure out some errors that were made along the way, but hopefully they have been fixed.
#LootDrop
LootDrop will have 3 Interfaces that will be in the class. There will be iComparer, IEquatable, & IComparable
LootDrop will implement IEquatable & IComparable.
Three things are needed for this class, which are Monster, DropNo, and Gold.
There is the public LootDrop that will set up the Monster, DropnNo, and Gold.
There will need to be two equals that need to be set up.
The first one is a bool for equals to set an if statement and have it return the monster, DropNo, & Gold.
The Next equals will have an override bool and have object.
Next is to set up an Override for GetHashCode and to have it return HashCode.Combine for monster, DropNo, Gold.
For the other thing you need is the CompareTo and have LootDrop other. You will need to set up if statements for the results
to compare Monster, DropNo, & Gold.
The last thing is the ToSpring() which you need to override and it will be the way to show the Monsters, the DropNo, & Gold.
This one did take the longest
#HighestValueFirst
HighestValueFirst will need to implement IComparer.
You will then need to set up a compare for lootdrop a and lootdrop b.
You will need to if statement and have it in Referenceequals for a and b.
this statement for gold.
#GroupByKey
GroupByKey is almost the same as HighestValueFirst but with a few changes
In the compare instead of it being gold, it will be monster.

#LootLog
IDisposable will be put into LootLog.
Here LootLog will implement IDisposable.
For Lootlog you will need Writer, path, count, and isclosed.
There will be a public Lootlog that will have path, count = 0, isclosed that is set to false, writer will have streamwriter(path).
You will then set up a void write for Lootdrop r.
The last thing will be void Dispose and set up the if statement on isclosed that should be true.
#IReportable
IReportable only has one thing and that would be the string ReportLine()

#IDiscountable
IDiscountable only needs IsOnSale with {get; } and saleprice set as decimal.
Both IDiscountable and IReportable were the easy ones to put in.
