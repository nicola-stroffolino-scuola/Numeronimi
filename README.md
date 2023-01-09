# Numeronimi
Cosa sono i numeronimi?
Un numeronimo è una parola basata su numeri. In particolare in lingua in lingua inglese sono presenti numeri che hanno una pronuncia simile a quella di alcune parole (es. 4u o up2you).
In un numeronimo, comunque, al di là della pronuncia, i numeri vengono utilizzati come forma di abbreviazione.
Alcuni numeoronimi sono di fatto standardizzati, altri invece no. In particolare in "gergo informatico" sono molto ultilizzati i numeronimi K8s per *kubernetes* e i18n per *internationalization*.
Da questi due numeronimi è facile capire il meccanismo di abbreviazione usato per la loro creazione: il numero rappresenta la quantità di lettere presenti tra la prima e l'ultima lettera della parola:
- ubernete -> 8 lettere
- nternationalizatio -> 18 lettere

Nel generare un numeronimo occorre fare attenzione ad alcune cose:
- per scrivere un numeronimo si usano sempre lettere minuscole, tranne l'eccezione al punto successivo
- la i maiuscola e la L minuscola possono facilmente confondersi. Per questo motivo se in un numeronimo sono presenti una i o una elle andranno utilizzate rispettivamente in minuscolo e in maiuscolo
- la parola Kubernetes e la parola kubernetes dovranno generare sempre il numeronimo K8s
- se il numeronimo è costituito da più di una parola, le singole parole del numeronimo dovranno essere separate da una @.
- se il metodo viene chiamato con mode = 0 il numeronimo dovrà, salvo i casi particolari indicati, contenere solo lettere minuscole
  - Es: Carlo Martello -> c3o@m6o
  - Analogo procedimento se le parole sono più di due.
- se il metodo viene chiamato con mode = 1 il numeronimo dovrà, salvo i casi particolari indicati, avrà sempre iniziali maiuscole
  - Es: Carlo Martello -> C3o@M6o
  - Analogo procedimento se le parole sono più di due.

L'esercizio prevede la scrittura del metodo Numeronimimyze che verrà utilizzato successivamente all'interno di una classe StringServices dedicata al processamento di stringhe.

Per saperne di più sulle origini dei numeronimi, si può consultare questa pagina di Wikipedia: [https://en.wikipedia.org/wiki/Numeronym](https://en.wikipedia.org/wiki/Numeronym)
