import Card from "./card";

// communicates with Deck of Cards API (https://deckofcardsapi.com/)
// to implement some card operations
// TODO: implement
export default class CardService {

    

    newDeck(): Promise<void> {
        return fetch('https://deckofcardsapi.com/api/deck/new/', {
            method: 'POST',
            headers: {
                'Accept' : 'Application/json'
            }

        })
            .then(response => response.json())
            .then(responseObj => {
                this.current
            })
        
    }

    

    drawCard(): Promise<Card> {
        return fetch('https://deckofcardsapi.com/api/deck/<<deck_id>>/draw/?count=2')
    }
}
