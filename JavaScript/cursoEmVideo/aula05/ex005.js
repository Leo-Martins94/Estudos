var p1 = document.getElementsByTagName('p')[0];
var body = document.body;
var d = document.querySelector('div#msg');

document.write(`<p>Este é o conteúdo do primeiro paragrafo ' ${p1.innerText} '</p>`);

p1.style.color = 'red';
body.style.background = 'gray';
//alert(p1.innerText)
d.style.background = 'green';
d.innerText = 'Estou aguardando...'