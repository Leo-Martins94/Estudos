//Array

let array = ['Leo', 1, true];
console.log(array[0])

let array2 = ['Leo', 0, true, ['Ana',1,false], ['Array2'], ['Array3', 10],['Array4','E assim por diante']]

console.log(array2)

//Manipulando Arrays

//forEach
array.forEach(function(item, index){console.log(item, index)})

//push
array.push("Ana")
console.log(array)

//pop - reomove o ultimo item do array
array.pop();
console.log(array);

//shift - romove o primeiro item do array
array.shift();
console.log(array);

//UnShift - adiciona um item no inico do array
array.unshift('Leo');
console.log(array);

//indexOf - informa o valor de indice de um item dentro do array
console.log(array.indexOf(true));

//splice - remove ou substitui um item por um indice

array.splice(0,1);
console.log(array);

//slice - retorna uma parte de um array

let novoArray = array.slice(0,1);
console.log(novoArray)

//Objetos

let object = {
    string: 'string',
    number: 1,
    boolean: true,
    array: ["Array"],
    objectInterno: {
        objectInterno: "Objeto Interno"
    }
}

console.log(object)
console.log(object.boolean)

//desestruturação de objeto

var string = object.string;
console.log(string)

//desinstruturação no meomento da declaração
var {string, boolean, objectInterno} = object;
console.log(string, boolean, objectInterno)