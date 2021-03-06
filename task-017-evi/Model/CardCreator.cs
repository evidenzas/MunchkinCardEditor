﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using munchkin_card_editor.Cards;
using munchkin_card_editor.Model.Doors;
using munchkin_card_editor.Model.Others;
using munchkin_card_editor.Model.Treasures;

namespace munchkin_card_editor.Model
{
    class CardCreator
    {
        public static Card CreateNewCard(string cardType)
        {
            switch (cardType)
            {
                case "Class card":
                    return new ClassCard();
                case "Curse card":
                    return new CurseCard();
                case "Modifier card":
                    return new ModifierCard();
                case "Monster card":
                    return new MonsterCard();
                case "Race card":
                    return new RaceCard();
                case "Go up a level card":
                    return new GoUpALevelCard();
                case "Item card":
                    return new ItemCard();
                case "One shot trasure card":
                    return new OneShotTreasureCard();
                case "Other card":
                    return new OtherCard();
            }
            return null;
        }

        public static void FillMainFieldsOfCard(Card card, string cardPicture, string cardName, string cardDesc)
        {
            card.PicturePath = cardPicture;
            card.Name = cardName;
            card.Description = cardDesc;
        }


        public static void FillAdvFiledsOfCard(ModifierCard card, string cardModifier, string modSign)
        {
            if (!string.IsNullOrEmpty(cardModifier)) card.Modifier = int.Parse(cardModifier);
            card.Sign = modSign;
        }

        public static void FillAdvFiledsOfCard(MonsterCard card, string cardLevel, string cardRace, string cardBadStuff, string cardTreasureReward, string cardLevelReward)
        {
            if (!string.IsNullOrEmpty(cardLevel)) card.Level = int.Parse(cardLevel);
            card.Race = cardRace;
            card.BadStuff = cardBadStuff;
            if (!string.IsNullOrEmpty(cardTreasureReward)) card.TreasureReward = int.Parse(cardTreasureReward);
            if (!string.IsNullOrEmpty(cardLevelReward)) card.LevelReward = int.Parse(cardLevelReward);
        }

        public static void FillAdvFiledsOfCard(ItemCard card, string cardModifier, string modSign, string cardRestriction, string cardPartOfBody, string сardCost, string cardIsBigItem)
        {
            if (!string.IsNullOrEmpty(cardModifier)) card.Modifier = int.Parse(cardModifier);
            card.Sign = modSign;
            card.Restriction = cardRestriction;
            card.PartOfBody = cardPartOfBody;
            card.Cost = сardCost;
            if (!string.IsNullOrEmpty(cardIsBigItem)) 
            {
                if (cardIsBigItem.Equals("True")) card.IsBigItem = true;
                else card.IsBigItem = false;
            }
            //bool.Parse(cardIsBigItem); - doesnt work
        }

        public static void FillAdvFiledsOfCard(OneShotTreasureCard card, string cardCost)
        {
            card.Cost = cardCost;
        }
    }
}
