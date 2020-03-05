* Data Sturcutre
** Combination
	Combination of cards
** PokerHand
	The type of pokerhand
	The  cards that make up this pokerhand
* Get the odds of a player winning and lossing [1/3]
	- Input: The player's hand, and the field
	- Output: The odds the player will win givein their hand
1. Get all possiple cards the CPU would have.
2. Generate all possiple hands/field comibnations the CPU would have
3. Compare all possiple hands/field combiantions the CPU would have with teh player.
** DONE 1.  Get all possiple cards the CPU would have.
	- Input: Player's hand and field
	- Output: All cards that hte CPU would have.
Create a deck, but if the player and field card is in the supposed deck, remove it.
Return the new deck
** TODO 2. Generate All possiple hands combinations the CPU would have
	- Input: The possiple cards the CPU would have
	- Output: The posspile hand/field combiantions the CPU would have
	- Create a list of possisple combiantions
	- Get each combinations of every two cards in the supposed deck, and field.
	  - Find the best value combiantion.
	    - Append that to combination list

	- Return possipleCombaitons
** TODO 3 Compare all possiple hands/field combations the CPU would have with the player [1/2]
	- Input : Possiple combiations the CPU could be, the player's hand's, and hte field.
	- Ouptut: The number of times the player wins, draws and losings
- 01 Get the possiple pokerCombs the player and CPU would have, given teh field.
- foreach combination in CPU's hand:
	- 02  Compare the player and CPU pokerComb, and if any use the excat same cards, remove them.
	- Increment the number of tiems the player Wins, Loses or draw.
*** TODO 01. Get the possiple pokerCombs the player and CPU would have, given teh field.
	- input: All of the CPU possiple cards, the players hand and teh field
	- Ouput: All of the possiple combiations of the CPU and player's hand
- Combine player's hadn with the field
- Store all possiple combianations of that.
- Do the same for each value of possiple CPU hands.
*** DONE 02. Compare the player and CPU pokerComb, and if any use the excat same cards, remove them.
	- input: Possiple combiations the player could have, and all possiple combiatons the CPU's hand would have, as well as the field
	- output: A winner of hte duel
- 001  Get the possiple pokerComb the player and CPU's combination can use, as well as the cards that make up those values.
- Remove the pokerComb on both Player and CPU that only use the field cards
- if There are no pokeraHands for either Player and CPU
	+ return draw
- else
	return who ever has the stronger pokerComb
**** 001. Get the possiple pokerCombs the player and CPU's combination can use, as well as the cards that make up those values.
	- input: The combination of cards
	- output: The type of pokerComb the combination has, as well as the cards that make up those values
- Sequential/Flush Checking : Straight/Flush Checking
	+ Sort Combination
		+ If there is an Ace and a king, reduce number of sequence you need by 1
		+ Check if combination is sequentail by 5 values
		+ Check if each card that is sequentail also has the suite
	- If they do have the same suite AND are sequential : Straight Flush
    - Else if all same suite :  Flush
    - Else if sequentail : straight
    - If there is a pokerComb from this, store it's combiation and cards.
- Same Occurance : Pair/three of a kind/two pair, full house, four of a kind
	+ For loop of index from 0 to 5
      + Create a list of Cards
      + if value in combination matches value in index : append card to list, to key of it's value
    + Count the number of occurances of each key in list
      + If it's a 2: it's a piar
      + if it's 3: three of a kind
      + if it's 4: four of a kind
      + If there's pair, it's two pairs.
      + if a piar/three of a kind happen at the same time, full house
      + Get value fo teh highest card in combiation, and that's highcard.
