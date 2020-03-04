
# Table of Contents

1.  [Information](#org1269354)
    1.  [Create a 5 card PokerHand class that implement ICompareable<PokerHand>](#org8341551)
    2.  [Rules/Probablity](#org76d6a57)
2.  [Rules](#org742f1b3)
    1.  [player vs computer - cheat and always start the hand with the 5 card shared board showing.](#org193598b)
    2.  [Odds Calcautor](#orgf4022c8)
    3.  [both players start with $100 and bet $10 each hand. Player always goes first.  Player can Raise $10 or fold.](#orgb12b5d8)
    4.  [The computer will call if 50% chance of winning or higher.](#org98e6567)
    5.  [Run until someone runs out of money.](#org50de76f)
3.  [Decompostion](#orga277bde)
    1.  [Setup](#org26d1888)
    2.  [Conditions](#orgf99fed9)
    3.  [Action](#orgb17d265)
    4.  [Data](#org7d4e0ea)



# Information



## Create a 5 card PokerHand class that implement ICompareable<PokerHand>



## Rules/Probablity

-   [Poker Hands](https://en.wikipedia.org/wiki/List_of_poker_hands)
-   [Texas Holdem Up](https://en.wikipedia.org/wiki/Texas_hold_%27em)



# Rules



## player vs computer - cheat and always start the hand with the 5 card shared board showing.



## Odds Calcautor

You see your 2 card and the 5 shared cards.  That leaves 45 cards you don't see.  There are 990 possible 2 card hands given those 45 cards you don't know.  Given each 990 2 card hand, find the best 5 card poker hand from the 21 possible hands.  Compare your best hand with those 990 best hands to generate odds of win/draw/lose.



## both players start with $100 and bet $10 each hand. Player always goes first.  Player can Raise $10 or fold.



## The computer will call if 50% chance of winning or higher.



## Run until someone runs out of money.

Given each 990 2 card hand, find the best 5 card poker hand from the 21 possible hands



# Decompostion



## Setup

-   **S1**  : The player and CPU's hand, as well as the current field
-   **S2** : A card from the randomly shuffle Deck
-   **S3** : Player goes first.
-   **S4** : Both players start with 100 dollars



## Conditions

-   **C1** : If the computer has 50% of winning or higher, than it calls
-   **C2** : Both palyers start with 100 dollars and bet 10$ on each term



## Action

-   **A1** : Player can either raise 10$ or fold
-   **A2** : The player can



## Data

-   **D1** : The chance of winning/losing/tie.
-   **D2** : The computer and field's hand
-   **D3** : The deck

