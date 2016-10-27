﻿/*
------------------------------------------------
Generated by Cradle 2.0.0.0 on 10/27/2016 14:14:43
https://github.com/daterre/Cradle

Original file: PatrickKennedy.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @PatrickKennedy: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;
	public readonly UnityTwineTestMacros macros2;

	@PatrickKennedy()
	{
		this.StartPassage = "Introduction";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new UnityTwineTestMacros() { Story = this };
	}
	
	void Awake() {
		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Introduction

	void passage1_Init()
	{
		this.Passages[@"Introduction"] = new StoryPassage(@"Introduction", new string[]{ "number-1", "OutsideEntrance", }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("You are Patrick Kennedy. You are 89 years old. You have worked as a servant for most of your life. When you weren't a servant, you worked odd jobs to survive. Your children are dead from disease. You were hoping they would take care of you in your old age. But now you have no family to help you, and you are too old to work. You apply to the parish for a weekly pension, but they deny you. Instead, they give you five shillings for present relief. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("You run out of money and have to apply for relief again", "You run out of money and have to apply for relief again", null);
		yield break;
	}


	// .............
	// #2: You run out of money and have to apply for relief again

	void passage2_Init()
	{
		this.Passages[@"You run out of money and have to apply for relief again"] = new StoryPassage(@"You run out of money and have to apply for relief again", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("The five shillings the committee gave you ran out. You don't want to starve, so you apply for relief again. The committee orders you into the workhouse.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go into the workhouse", "Go into the workhouse", null);
		yield return lineBreak();
		yield return link("Choose not to go into the workhouse", "Choose not to go into the workhouse", null);
		yield break;
	}


	// .............
	// #3: Go into the workhouse

	void passage3_Init()
	{
		this.Passages[@"Go into the workhouse"] = new StoryPassage(@"Go into the workhouse", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("You meet the master and matron of the house. You and your wife are seperated. She goes with the matron. You go with the master. You are given a bucket of water and told to wash. After you wash, your old clothes are taken from you, and you are given new, scratchy wool clothes instead. All your personal belongings are taken away. You don't know where the master puts them. You are ordered to report to work immediately.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Follow the order and go to work", "Follow the order and go to work", null);
		yield return lineBreak();
		yield return link("Realize that entering the workhouse was a mistake and try to leave", "Realize that entering the workhouse was a mistake and try to leave", null);
		yield break;
	}


	// .............
	// #4: Choose not to go into the workhouse

	void passage4_Init()
	{
		this.Passages[@"Choose not to go into the workhouse"] = new StoryPassage(@"Choose not to go into the workhouse", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Life is hard. You are unable to find work, and you and your wife are starving. You choose to beg on the streets, and you are unfortunately picked up by the police. You are taken to the parish and put into the workhouse.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go into the workhouse", "Go into the workhouse", null);
		yield return text(" ");
		yield return lineBreak();
		yield break;
	}


	// .............
	// #5: Follow the order and go to work

	void passage5_Init()
	{
		this.Passages[@"Follow the order and go to work"] = new StoryPassage(@"Follow the order and go to work", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("Go to work. You are ordered to sweep the floor while people are spinning. The work is tedious. You are relieved when the workhouse master rings a bell and announces that lunch will be served.  ");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to the dining room for lunch", "Go to the dining room for lunch", null);
		yield break;
	}


	// .............
	// #6: Realize that entering the workhouse was a mistake and try to leave

	void passage6_Init()
	{
		this.Passages[@"Realize that entering the workhouse was a mistake and try to leave"] = new StoryPassage(@"Realize that entering the workhouse was a mistake and try to leave", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("You try to walk out the front door. The master of the workhouse stops you and gently leads you back to your room and tells you to lie down.");
		yield return lineBreak();
		yield return link("Go to the dining room for lunch", "Go to the dining room for lunch", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #7: Eat before the prayer is finished

	void passage7_Init()
	{
		this.Passages[@"Eat before the prayer is finished"] = new StoryPassage(@"Eat before the prayer is finished", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("Your hunger overcomes you, and you choose to eat before the prayer ends. Drats! The workhouse master has caught you! You are reprimanded by recieving half rations for dinner.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to the family room", "Go to the family room", null);
		yield break;
	}


	// .............
	// #8: Wait until the prayer is finished to start eating

	void passage8_Init()
	{
		this.Passages[@"Wait until the prayer is finished to start eating"] = new StoryPassage(@"Wait until the prayer is finished to start eating", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("You are able to wait till the prayer ends and you enjoy your entire meal. Afterwards, you are tired and go to lay down in the family room.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to the family room", "Go to the family room", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #9: Go to the dining room for lunch

	void passage9_Init()
	{
		this.Passages[@"Go to the dining room for lunch"] = new StoryPassage(@"Go to the dining room for lunch", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("When you arrive in the dining room for lunch, you are served a boiled onion and bread. Prior to eating, the workhouse master leads everyone with a prayer, however, the prayer is long and you are very hungry.");
		yield return lineBreak();
		yield return link("Eat before the prayer is finished", "Eat before the prayer is finished", null);
		yield return lineBreak();
		yield return link("Wait until the prayer is finished to start eating", "Wait until the prayer is finished to start eating", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #10: Go to the family room

	void passage10_Init()
	{
		this.Passages[@"Go to the family room"] = new StoryPassage(@"Go to the family room", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("You try to take a nap, but you can hear the spinning wheels in the adjacent rooms. You try to sneak outside for some fresh air. The workhouse master catches you again. He brings you back inside.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Lie down again", "Lie down again", null);
		yield return lineBreak();
		yield return link("Try to escape through a hole in the wall", "Try to escape through a hole in the wall", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #11: Lie down again

	void passage11_Init()
	{
		this.Passages[@"Lie down again"] = new StoryPassage(@"Lie down again", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("The bell rings for dinner. You wake up and head back to the dining room to eat once more. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to the dining room", "Go to the dining room", null);
		yield break;
	}


	// .............
	// #12: Try to escape through a hole in the wall

	void passage12_Init()
	{
		this.Passages[@"Try to escape through a hole in the wall"] = new StoryPassage(@"Try to escape through a hole in the wall", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("Unfortunately, 89 year old men are not agile nor flexible enough to escape through this hole. Your workhouse master catches you redhanded in the act. He confines you to your room.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to Sleep", "Go to Sleep", null);
		yield break;
	}


	// .............
	// #13: Go to the dining room

	void passage13_Init()
	{
		this.Passages[@"Go to the dining room"] = new StoryPassage(@"Go to the dining room", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("For dinner you are served the scrumptious meal of suet pudding, which is made of disgusting materials. Delicious. After dinner, you are ordered back to your room and are told to prepare for bed.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Return to the family room", "Return to the family room", null);
		yield break;
	}


	// .............
	// #14: Go to Sleep

	void passage14_Init()
	{
		this.Passages[@"Go to Sleep"] = new StoryPassage(@"Go to Sleep", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("It's been a long day, and you are tired. You can't believe you survived your first day in the workhouse as it has been a long ordeal. You close your eyes and hope tomorrow will be better. ");
		yield break;
	}


	// .............
	// #15: Return to the family room

	void passage15_Init()
	{
		this.Passages[@"Return to the family room"] = new StoryPassage(@"Return to the family room", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("You see your lovely wife, who has been working all day and is a tad bit grumpy. Anyways, it is nice to see her again, and you talk about your days. The workhouse master yells, \"lights out\" and you and your wife go to bed.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to Sleep", "Go to Sleep", null);
		yield return text(" ");
		yield return lineBreak();
		yield break;
	}


}