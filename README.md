# CodeRetreat

Helps getting started with the CodeRetreat exercise.

### CSharp

In the CS folder you'll find a template project with MSpec already installed. Please enable NCrunch so your tests will run automagically.

### Javascript

If you want to explore ES6 you can go to the JS6 folder. It uses Google's traceur to transpile into JS5
To get started:

1. Run ```npm install```
2. Run ```npm install -g bower``` (If you don't have bower)
3. Run ```bower install```
4. Run ```gulp```
5. Open a browser and navigate to http://localhost:9000/default.html
6. Now you can start running you JS implementation of The Game of Life using ES6. You can use TDD, while doing changes, the browser will be reloaded and tests will be executed automagically. When you add a new spec class, please include that in the default.html so your tests will start running.


# Rules of Conway's Game of Life

For every cell in the universe:

### Under-population: 
Any cell with fewer than two live neighbours dies

### Survive:
Any live cell with two or three live neighbours lives on the next generation

### Overcrowding:
Any live cell with more than three live neighbours dies

### Reproduction: 
Any dead cell with exactly three live neighbours becomes a live cell
