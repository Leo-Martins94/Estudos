package one.digitalInovation.collections

class Repositorio<f> {
    private val map = mutableMapOf<String, f>()

    fun create(id: String, value:f){
        map[id] = value
    }

    fun remove(id: String) = map.remove(id)

    fun findById(id: String) = map[id]

    fun findAll() = map.values

}