var count = 0;
function countBits(n) {
  var dec;
  
  if (n < 0) {
    console.log(`o numero digitado foi ${n}, digite um numero maior que 0`)
  } else {
    //dec = (n >>> 0).toString(2);
    dec = parseInt(n, 10).toString(2);
    console.log(dec)
    for (let i = 0; i <= dec.length; i++) {
      if (dec[i] == 1) {
        console.log('encontrei um 1');
        count++;
      }
    }
  }
  return count
};

console.log(countBits(7983538195));

