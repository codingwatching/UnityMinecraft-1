﻿using UnityEngine;

public class Registrar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		this.RegisterBlocks();
		this.RegisterItems();
		this.RegisterCraftingRecipes();
    }

	void RegisterBlocks()
	{
		Registry.RegisterItem<Air>("air");
        Registry.RegisterItem<Cobblestone>("cobblestone");
		Registry.RegisterItem<Stone>("stone");
		Registry.RegisterItem<Dirt>("dirt");
		Registry.RegisterItem<Grass>("grass");
		Registry.RegisterItem<Bedrock>("bedrock");
		Registry.RegisterItem<CraftingTable>("craftingTable");
		Registry.RegisterItem<Furnace>("furnace");
		Registry.RegisterItem<OreCoal>("oreCoal");
		Registry.RegisterItem<OreIron>("oreIron");
		Registry.RegisterItem<OreDiamond>("oreDiamond");
		Registry.RegisterItem<OreEmerald>("oreEmerald");
		Registry.RegisterItem<OreGold>("oreGold");
		Registry.RegisterItem<Log>("log");
		Registry.RegisterItem<Planks>("planks");
		Registry.RegisterItem<Leaves>("leaves");
		Registry.RegisterItem<IronBlock>("ironBlock");
		Registry.RegisterItem<GoldBlock>("goldBlock");
		Registry.RegisterItem<DiamondBlock>("diamondBlock");
		Registry.RegisterItem<EmeraldBlock>("emeraldBlock");
		Registry.RegisterItem<RainbowGenerator>("rainbowGenerator");
		Registry.RegisterItem<Limestone>("rockLimestone");
		Registry.RegisterItem<TNT>("tnt");
		Registry.RegisterItem<OreRedstone>("oreRedstone");
		Registry.RegisterItem<LimestoneSaltpeter>("saltpeterOre");
		Registry.RegisterItem<SulfurBlock>("sulfurBlock");
		Registry.RegisterItem<OreSulfur>("oreSulfur");
		Registry.RegisterItem<Water>("water");
		Registry.RegisterItem<Clay>("clay");
		Registry.RegisterItem<Sand>("sand");
		Registry.RegisterItem<Glass>("glass");
		Registry.RegisterItem<Snow>("snow");
		Registry.RegisterItem<Granite>("granite");
		Registry.RegisterItem<Diorite>("diorite");
		Registry.RegisterItem<Andesite>("andesite");
	}

	void RegisterItems()
	{
		Registry.RegisterItem<Torch>("torch");
		Registry.RegisterItem<Coal>("coal");
		Registry.RegisterItem<Diamond>("diamond");
		Registry.RegisterItem<Emerald>("emerald");
		Registry.RegisterItem<IngotIron>("ironIngot");
		Registry.RegisterItem<IngotGold>("goldIngot");
		Registry.RegisterItem<WoodPickaxe>("woodPickaxe");
		Registry.RegisterItem<StonePickaxe>("stonePickaxe");
		Registry.RegisterItem<IronPickaxe>("ironPickaxe");
		Registry.RegisterItem<GoldPickaxe>("goldPickaxe");
		Registry.RegisterItem<DiamondPickaxe>("diamondPickaxe");
		Registry.RegisterItem<Stick>("stick");
		Registry.RegisterItem<Apple>("apple");
		Registry.RegisterItem<Petroleum>("petroleum");
		Registry.RegisterItem<Redstone>("redstone");
		Registry.RegisterItem<Saltpeter>("saltpeter");
		Registry.RegisterItem<Charcoal>("charcoal");
		Registry.RegisterItem<Sulfur>("sulfur");
		Registry.RegisterItem<Gunpowder>("gunpowder");
		Registry.RegisterItem<ClayBall>("clayBall");
		Registry.RegisterItem<Brick>("brick");
		Registry.RegisterItem<BrickBlock>("brickBlock");
		Registry.RegisterItem<Snowball>("snowball");
		Registry.RegisterItem<RawIron>("rawIron");
	}

	void RegisterCraftingRecipes()
	{

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"coal", null, null},
				{"stick", null, null},
				{null, null, null}
			}, 
			new CraftingResult("torch", 4)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"brick", "brick", "brick"},
				{"brick", "brick", "brick"},
				{"brick", "brick", "brick"}
			}, 
			new CraftingResult("brickBlock", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"planks", null, null},
				{"planks", null, null},
				{null, null, null}
			}, 
			new CraftingResult("stick", 4)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"log", null, null},
				{"log", null, null},
				{null, null, null}
			}, 
			new CraftingResult("stick", 16)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"planks", "planks", "planks"},
				{null, "stick", null},
				{null, "stick", null}
			}, 
			new CraftingResult("woodPickaxe", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"cobblestone", "cobblestone", "cobblestone"},
				{null, "stick", null},
				{null, "stick", null}
			}, 
			new CraftingResult("stonePickaxe", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"ironIngot", "ironIngot", "ironIngot"},
				{null, "stick", null},
				{null, "stick", null}
			}, 
			new CraftingResult("ironPickaxe", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"goldIngot", "goldIngot", "goldIngot"},
				{null, "stick", null},
				{null, "stick", null}
			}, 
			new CraftingResult("goldPickaxe", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"diamond", "diamond", "diamond"},
				{null, "stick", null},
				{null, "stick", null}
			}, 
			new CraftingResult("diamondPickaxe", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"diamond", "diamond", "diamond"},
				{"diamond", "diamond", "diamond"},
				{"diamond", "diamond", "diamond"}
			}, 
			new CraftingResult("diamondBlock", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"charcoal", "saltpeter", "sulfur"},
				{null, null, null},
				{null, null, null}
			}, 
			new CraftingResult("gunpowder", 2)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"sulfur", "sulfur", "sulfur"},
				{"sulfur", "sulfur", "sulfur"},
				{"sulfur", "sulfur", "sulfur"}
			}, 
			new CraftingResult("sulfurBlock", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"emerald", "emerald", "emerald"},
				{"emerald", "emerald", "emerald"},
				{"emerald", "emerald", "emerald"}
			}, 
			new CraftingResult("emeraldBlock", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"goldIngot", "goldIngot", "goldIngot"},
				{"goldIngot", "goldIngot", "goldIngot"},
				{"goldIngot", "goldIngot", "goldIngot"}
			}, 
			new CraftingResult("goldBlock", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"ironIngot", "ironIngot", "ironIngot"},
				{"ironIngot", "ironIngot", "ironIngot"},
				{"ironIngot", "ironIngot", "ironIngot"}
			}, 
			new CraftingResult("ironBlock", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"diamondBlock", null, null},
				{null, null, null},
				{null, null, null}
			}, 
			new CraftingResult("diamond", 9)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"emeraldBlock", null, null},
				{null, null, null},
				{null, null, null}
			}, 
			new CraftingResult("emerald", 9)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"goldBlock", null, null},
				{null, null, null},
				{null, null, null}
			}, 
			new CraftingResult("goldIngot", 9)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"ironBlock", null, null},
				{null, null, null},
				{null, null, null}
			}, 
			new CraftingResult("ironIngot", 9)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"log", null, null},
				{null, null, null},
				{null, null, null}
			}, 
			new CraftingResult("planks", 4)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"cobblestone", "cobblestone", "cobblestone"},
				{"cobblestone", null, "cobblestone"},
				{"cobblestone", "cobblestone", "cobblestone"}
			}, 
			new CraftingResult("furnace", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"planks", "planks", null},
				{"planks", "planks", null},
				{null, null, null}
			}, 
			new CraftingResult("craftingTable", 1)
		));

		CraftingRecipeRegistry.RegisterRecipe(
			new CraftingRecipe(new string[3,3] {
				{"goldBlock", "diamondBlock", "goldBlock"},
				{"ironIngot", "emeraldBlock", "ironIngot"},
				{"goldBlock", "diamondBlock", "goldBlock"}
			}, 
			new CraftingResult("rainbowGenerator", 1)
		));
	}
}
