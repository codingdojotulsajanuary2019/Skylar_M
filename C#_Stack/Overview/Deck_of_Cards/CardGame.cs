using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Card
    {
        string StringVal {get; set;}

        string Suit {get;set;}
        
        int Val {get;set;}

        public Card(string stringVal, string suit, int val){
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }

        public void GetInfo(){
            Console.WriteLine($"Val: {StringVal}");
            Console.WriteLine($"Suit: {Suit}");
            Console.WriteLine($"Num: {Val}");
        }

    }
    public class Deck
    {
        List<Card> Cards {get;set;}

        public Deck(){
            Cards = new List<Card>(){
                new Card("Ace", "Spades", 1), 
                new Card("two", "Spades", 2), 
                new Card("three", "Spades", 3), 
                new Card("four", "Spades", 4), 
                new Card("five", "Spades", 5), 
                new Card("six", "Spades", 6), 
                new Card("seven", "Spades", 7), 
                new Card("eight", "Spades", 8), 
                new Card("nine", "Spades", 9), 
                new Card("ten", "Spades", 10), 
                new Card("Jack", "Spades", 11), 
                new Card("Queen", "Spades", 12), 
                new Card("King", "Spades", 13),
                new Card("Ace", "Clubs", 1), 
                new Card("two", "Clubs", 2), 
                new Card("three", "Clubs", 3), 
                new Card("four", "Clubs", 4), 
                new Card("five", "Clubs", 5), 
                new Card("six", "Clubs", 6), 
                new Card("seven", "Clubs", 7), 
                new Card("eight", "Clubs", 8), 
                new Card("nine", "Clubs", 9), 
                new Card("ten", "Clubs", 10), 
                new Card("Jack", "Clubs", 11), 
                new Card("Queen", "Clubs", 12), 
                new Card("King", "Clubs", 13),
                new Card("Ace", "Hearts", 1), 
                new Card("two", "Hearts", 2), 
                new Card("three", "Hearts", 3), 
                new Card("four", "Hearts", 4), 
                new Card("five", "Hearts", 5), 
                new Card("six", "Hearts", 6), 
                new Card("seven", "Hearts", 7), 
                new Card("eight", "Hearts", 8), 
                new Card("nine", "Hearts", 9), 
                new Card("ten", "Hearts", 10), 
                new Card("Jack", "Hearts", 11), 
                new Card("Queen", "Hearts", 12), 
                new Card("King", "Hearts", 13),
                new Card("Ace", "Diamonds", 1), 
                new Card("two", "Diamonds", 2), 
                new Card("three", "Diamonds", 3), 
                new Card("four", "Diamonds", 4), 
                new Card("five", "Diamonds", 5), 
                new Card("six", "Diamonds", 6), 
                new Card("seven", "Diamonds", 7), 
                new Card("eight", "Diamonds", 8), 
                new Card("nine", "Diamonds", 9), 
                new Card("ten", "Diamonds", 10), 
                new Card("Jack", "Diamonds", 11), 
                new Card("Queen", "Diamonds", 12), 
                new Card("King", "Diamonds", 13),
            };
        }

        public void Shuffle(){
            /* for(int i = 0; i < Cards.Count; i++){
                Cards[i].GetInfo();
                Console.WriteLine("-------------");
            } */
            
            int n = Cards.Count;
            Random Rand = new Random();
            while(n > 1){
                int k = (Rand.Next(0, n) % n);
                n--;
                Card Value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = Value;
            }
            
            /* Console.WriteLine("----------------------------------");
            Console.WriteLine("**Shuffle**");
            Console.WriteLine("----------------------------------");
            
            for(int i = 0; i < Cards.Count; i++){
                Cards[i].GetInfo();
                Console.WriteLine("-------------");
            } */
            
        }
        public Card Deal(){
            Card Draw = Cards[0];
            Cards.RemoveAt(0);
            return Draw;
        }
        public void ResetDeck(){
            Cards.Clear();
            Cards = new List<Card>(){
                new Card("Ace", "Spades", 1), 
                new Card("two", "Spades", 2), 
                new Card("three", "Spades", 3), 
                new Card("four", "Spades", 4), 
                new Card("five", "Spades", 5), 
                new Card("six", "Spades", 6), 
                new Card("seven", "Spades", 7), 
                new Card("eight", "Spades", 8), 
                new Card("nine", "Spades", 9), 
                new Card("ten", "Spades", 10), 
                new Card("Jack", "Spades", 11), 
                new Card("Queen", "Spades", 12), 
                new Card("King", "Spades", 13),
                new Card("Ace", "Clubs", 1), 
                new Card("two", "Clubs", 2), 
                new Card("three", "Clubs", 3), 
                new Card("four", "Clubs", 4), 
                new Card("five", "Clubs", 5), 
                new Card("six", "Clubs", 6), 
                new Card("seven", "Clubs", 7), 
                new Card("eight", "Clubs", 8), 
                new Card("nine", "Clubs", 9), 
                new Card("ten", "Clubs", 10), 
                new Card("Jack", "Clubs", 11), 
                new Card("Queen", "Clubs", 12), 
                new Card("King", "Clubs", 13),
                new Card("Ace", "Hearts", 1), 
                new Card("two", "Hearts", 2), 
                new Card("three", "Hearts", 3), 
                new Card("four", "Hearts", 4), 
                new Card("five", "Hearts", 5), 
                new Card("six", "Hearts", 6), 
                new Card("seven", "Hearts", 7), 
                new Card("eight", "Hearts", 8), 
                new Card("nine", "Hearts", 9), 
                new Card("ten", "Hearts", 10), 
                new Card("Jack", "Hearts", 11), 
                new Card("Queen", "Hearts", 12), 
                new Card("King", "Hearts", 13),
                new Card("Ace", "Diamonds", 1), 
                new Card("two", "Diamonds", 2), 
                new Card("three", "Diamonds", 3), 
                new Card("four", "Diamonds", 4), 
                new Card("five", "Diamonds", 5), 
                new Card("six", "Diamonds", 6), 
                new Card("seven", "Diamonds", 7), 
                new Card("eight", "Diamonds", 8), 
                new Card("nine", "Diamonds", 9), 
                new Card("ten", "Diamonds", 10), 
                new Card("Jack", "Diamonds", 11), 
                new Card("Queen", "Diamonds", 12), 
                new Card("King", "Diamonds", 13),
            };
            
        }


    }
    public class Player
    {
        public string Name{get;set;}

        public List<Card> Hand {get;set;}

        public Player(){
            Hand = new List<Card>();
        }
        public Card Draw(Deck deck){
            Card newCard = deck.Deal();
            Hand.Add(newCard);
            return newCard;
        }
        public Card Discard(int Idx){
            if(Hand[Idx] != null){
                Card discard = Hand[Idx];
                Hand.RemoveAt(Idx);
                return discard;
            }
            else{
                return null;
            }
        }

    }
}