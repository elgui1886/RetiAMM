# RetiAMM
Esempi tratti dal corso SignalR

In questo esempio viene configurato un WCF di tipo Rest [MDMWCFService] - modifica al web config - che espone dei metodi.

In un altro dominio (altro progetto, localhost lavora su porte diverse), viene
configurato un sito web [WDM] che dialoga con un hub posto dentro al WCF.

L'hub invia informazioni ogni 3 secondi al client.
Per consentire il dialogo tra domini diversi deve essere configurato il WCF Hub nella classe
Startup.cs ad accettare connessione ExtraDomain.

Si inserisce poi un terzo attore [SAC] (in forma di web form, ma poteva essere altro), al quale vorremmo fare invocare un 
metodo del servizio di MDMWCFService e a seguito di questo evento il MDMWCFService segnali all'hub che tutti i clienti 
connessi vengano aggiornati.
