#Programação orientada a objetos

#import
import random

#Board

board = [
    '''''
    >>>>>>>>>>Hangman<<<<<<<<<<
    
    +---+
    |   |
        |
        |
        |
        |
    ========''','''''
    
    +---+
    |   |
    O   |
        |
        |
        |
    ========''','''''
    +---+
    |   |
    O   |
    |   |
        |
        |
    ========''','''''
    
    +---+
    |   |
    O   |
   /|   |
        |
        |
   ======== ''','''''
    +---+
    |   |
    O   |
   /|\  |
        |
        |
   ========''','''''
    +---+
    |   |
    O   |
   /|\  |
   /    |
        |
   ======== ''','''''
    +---+
    |   |
    O   |
   /|\  |
   / \  |
        |
   ========= '''
]

#Class
class Hangman:

    #Method
    def __init__(self,word):
        self.word = word
        self.missedLetters = []
        self.guessedLetters = []
    #Method guess the word
    def guess(self,letter):
        if letter in self.word and letter not in self.guessedLetters:
             self.guessedLetters.append(letter)
        elif letter not in self.word and letter not in self.missedLetters:
            self.missedLetters.append(letter)
        else:
            return False
        return True
    #Method check game over
    def hangmanOver(self):
        return self.hangmanWon() or (len(self.missedLetters) == 6)

    #Method check player win
    def hangmanWon(self):
        if '_' not in self.hideWord():
            return True
        return False
    #method hide board letter
    def hideWord(self):
        rtn = ''
        for letter in self.word:
            if letter not in self.guessedLetters:
                rtn += '_'
            else:
                rtn += letter
            return rtn
    #method check game status and print board
    def printGamStatus(self):
        print(board[len(self.missedLetters)])
        print('\nPalavra: '+self.hideWord())
        print('\nLetras erradas: ',)
        for letter in self.missedLetters:
            print(letter,)
        print()
        print('letras corretas: ',)
        for letter in self.guessedLetters:
            print(letter,)
        print()

#Function for read sort word from data base
def randWord():
    with open("words","rt") as f:
        bank = f.readlines()
    return bank[random.randint(0,len(bank))].strip()

#Function Main - Run the Program
def main():

    #Object
    game = Hangman(randWord())

    while not game.hangmanOver():
        game.printGamStatus()
        userInput = input('\nDigite uma letra: ')
        game.guess(userInput)

    #Check game status
    game.printGamStatus()

    #Print game status
    if game.hangmanWon():
        print('\nParabéns! voce ganhou')
    else:
        print('\nVoce perdeu\n a palavra era' + game.word)
    print('Foi bom jgar com voce, agora volte aos estudos')

if __name__ == '__main__':
    main()


