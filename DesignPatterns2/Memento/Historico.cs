﻿namespace DesignPatterns2.Memento; 

public class Historico {
    private IList<Estado> Estados = new List<Estado>();

    public void Adiciona(Estado estado) {
        Estados.Add(estado);
    }

    public Estado Pega(int indice) {
        return Estados[indice];
    }
}