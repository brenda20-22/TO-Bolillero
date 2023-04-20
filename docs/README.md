## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +Adentro List~int~
        +Afuera List~int~
        +Jugada List~int~ 
        +SacarBolilla() int 
        +Jugar(List~int~) bool
        +JugarNveces(List~int~,int) int
        +MeterBolillas() 
        }
    class IAzar{
        <<interface>>
        +IndiceAleatorio(List~int~) int
        }
    class AzarRandom{
        +IndiceAleatorio(List~int~) int
    }

    Bolillero --> IAzar
    AzarRandom ..|> IAzar
```