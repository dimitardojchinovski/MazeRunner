﻿# MazeRunner

"MazeRunner" е едноставна игра, каде што со коцка се поминува лавиринтот и се стигнува до целта, знаменцето. На самиот почеток од програмата се наоѓаат три копчиња "Старт", "Инструкции", "Излез". Со притискањето на копчето старт се отвара прозорецот од играта. Во играта се наоѓа коцката која што треба да се движи низ лавиринтот, а низ лавиринтот постојат пречки кои оневозможуваат движење на коцката. Знаменцето означува крај на играта. Исто така на почетниот прозорец има копче инструкции и излез од програмата. Во програмата се искористени два тајмери, едниот е искористен за знаменцето како "event" кој означува крај на играта, а другиот е за самите пречки кои не смеат да бидат допрени. Исто така има и две функции dolu() се користи за придвижување на коцката со стрелките од тастатурата, а додека MoveToStart() се користи за враќање на почетната локација при допир на пречките.

### Главен екран
![MazeRunner, ScreenShot1](https://raw.githubusercontent.com/dimitardojchinovski/MazeRunner/master/ScreenShots/MazeRunner.png)
### Старт
![Start, ScreenShot2](https://raw.githubusercontent.com/dimitardojchinovski/MazeRunner/master/ScreenShots/Start.png)
### Инструкции
![Instruction, ScreenShot3](https://raw.githubusercontent.com/dimitardojchinovski/MazeRunner/master/ScreenShots/Instruction.png)
### Не допирај прозорец
![DontTouch, ScreenShot4](https://raw.githubusercontent.com/dimitardojchinovski/MazeRunner/master/ScreenShots/DontTouch.png)
### Победник прозорец
![Winner, ScreenShot5](https://raw.githubusercontent.com/dimitardojchinovski/MazeRunner/master/ScreenShots/Winner.png)

Правила:
- Во текот на играта не смее да се допираат пречките кои се поставени.

Целта:
- Пронаоѓање на вистинскиот пат низ лавиринтот до знаменцето.