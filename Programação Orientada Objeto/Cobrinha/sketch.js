var s;
var tamanho = 20;

var comidinha;

function setup() {
  createCanvas(600, 600);
  s = new Cobrinha();
  frameRate(15);
  pickLocation();
}

function pickLocation() {
  var colunas = floor(width/tamanho);
  var linhas = floor(height/tamanho);
  comidinha = createVector(floor(random(colunas)), floor(random(linhas)));
  comidinha.mult(tamanho);
}

function mousePressed() {
  s.total++;
}

function draw() {
  background(0);

  if (s.eat(comidinha)) {
    pickLocation();
  }
  s.death();
  s.update();
  s.show();


  fill(333, 0, 0);
  rect(comidinha.x, comidinha.y, tamanho, tamanho);
}

function keyPressed() {
  if (keyCode === UP_ARROW) {
    s.dir(0, -1);
  } else if (keyCode === DOWN_ARROW) {
    s.dir(0, 1);
  } else if (keyCode === RIGHT_ARROW) {
    s.dir(1, 0);
  } else if (keyCode === LEFT_ARROW) {
    s.dir(-1, 0);
  }
}
