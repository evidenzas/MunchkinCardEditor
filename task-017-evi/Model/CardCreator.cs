using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_017_evi.Cards;
using task_017_evi.Model.Doors;
using task_017_evi.Model.Others;
using task_017_evi.Model.Treasures;

namespace task_017_evi.Model
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

        public static void FillMainFieldsOfCard(Card card, Image cardPicture, string cardName, string cardDesc)
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

        public static void FillAdvFiledsOfCard(ItemCard card, string cardModifier, string modSign, string cardRaceRestriction, string cardPartOfBody, string сardCost, string cardIsBigItem)
        {
            if (!string.IsNullOrEmpty(cardModifier)) card.Modifier = int.Parse(cardModifier);
            card.Sign = modSign;
            card.RaceRestriction = cardRaceRestriction;
            card.PartOfBody = cardPartOfBody;
            if (!string.IsNullOrEmpty(сardCost)) card.Cost = int.Parse(сardCost);
            if (!string.IsNullOrEmpty(cardIsBigItem)) card.IsBigItem = bool.Parse(cardIsBigItem);
        }

        public static void FillAdvFiledsOfCard(OneShotTreasureCard card, string cardCost)
        {
            if (!string.IsNullOrEmpty(cardCost)) card.Cost = int.Parse(cardCost);
        }

        /*
        switch (typeof(card))
            {
                case "Modifier card":
                    break;
                case "Monster card":
                    break;
                case "Item card":
                    break;
                case "One shot trasure card":
                    break;
            }
         */

    }
}
