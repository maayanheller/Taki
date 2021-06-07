#Taki
A simulation of the card game "Taki", with the number cards only.
The project is considered as the final of the tenth grade in the artificial intelligence.
The project is limited with learning materials such as dictionaries, external libraries for graphics, etc.

#Algorithm
```
    INPUT num of players playing;
    IF (typeof input != int) {
        end program
    }

    ELSE {
        CreateDeck();
        ShuffleDeck();
        TakeTopCard();
        DealCards();
        WHILE(FLAG == TRUE) {
            FOR(INT i = 0; i < players.length; i++) {
                try {
                    players[i].searchMatchingCard();
                    IF(players[i].cardsamount() == 0) {
                        end program;
                    }
                }

                catch {
                   deck.givecardstoplayer(players[i]);
                   IF(deck.cardsamount() == 0) {
                        end program;
                    }
                }
            }
        }
    }

```
