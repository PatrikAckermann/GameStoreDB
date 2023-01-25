using GameStoreDB.Data;
using GameStoreDB.Models;

using GameStoreContext context = new GameStoreContext();

var Spiele = context.Spiele
    .OrderBy(p => p.MaxSpieler) // Sortiert nach maximaler Spielerzahl
    .Where(p => p.Name == "Uno") // Nur Spiele mit dem Namen Uno
    .FirstOrDefault(); // Nur das erste Ergebnis laden
context.Spiele.Remove(Spiele); // Entität löschen
context.SaveChanges(); // Speichern

