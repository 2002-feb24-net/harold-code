import Card from "./card";

// communicates with Deck of Cards API (https://deckofcardsapi.com/)
// to implement some card operations
// TODO: implement
export default class CardService {

    

    newDeck(): Promise<Response> {
        return fetch('https://deckofcardsapi.com/api/deck/new/');
        
    }

    

    drawCard(): Promise<Card> {
        return fetch('https://deckofcardsapi.com/api/deck/<<deck_id>>/draw/?count=2')
    }
}
