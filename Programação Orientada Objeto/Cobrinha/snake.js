function Cobrinha() {
  this.x = 0;
  this.y = 0;
  this.xvelocidade = 1;
  this.yvelocidade = 0;
  this.total = 0;
  this.rabinho = [];

  this.eat = function(pos) {
    var d = dist(this.x, this.y, pos.x, pos.y);
    if (d < 1) {
      this.total++;
      return true;
    } else {
      return false;
    }
  }

  this.dir = function(x, y) {
    this.xvelocidade = x;
    this.yvelocidade = y;
  }

  this.death = function() {
    for (var i = 0; i < this.rabinho.length; i++) {
      var pos = this.rabinho[i];
      var d = dist(this.x, this.y, pos.x, pos.y);
      if (d < 1) {
        console.log('nova chance');
        this.total = 0;
        this.rabinho = [];
      }
    }
  }

  this.update = function() {
    for (var i = 0; i < this.rabinho.length - 1; i++) {
      this.rabinho[i] = this.rabinho[i + 1];
    }
    if (this.total >= 1) {
      this.rabinho[this.total - 1] = createVector(this.x, this.y);
    }

    this.x = this.x + this.xvelocidade * tamanho;
    this.y = this.y + this.yvelocidade * tamanho;

    this.x = constrain(this.x, 0, width - tamanho);
    this.y = constrain(this.y, 0, height - tamanho);
  }

  this.show = function() {
    fill(255);
    for (var i = 0; i < this.rabinho.length; i++) {
      rect(this.rabinho[i].x, this.rabinho[i].y, tamanho, tamanho);
    }
    rect(this.x, this.y, tamanho, tamanho);

  }
}
