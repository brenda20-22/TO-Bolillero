## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +cantBolillas: int 
        +SacarBolilla() int 
        +Jugar(List~int~) bool
        +JugarNveces(List~int~, int) int
        +MeterBolillas() 
        }
    class IAzar{
        <<interface>>
        +Numaleatorios: int
        +ElegirBolilla(List~int~)
        }
    class AzarRandom{
        Numaleatorios: int
        ElegirBolilla() int
    }

    Bolillero --> IAzar
    AzarRandom ..|> IAzar
```