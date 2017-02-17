package com.cegeka.DigitalSecretBox.domain.pineapples;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.HashSet;

@Component
public class PineappleRepository {

    public HashSet<Pineapple> pineapples;

    public PineappleRepository(HashSet<Pineapple> pineapples) {
        this.pineapples = pineapples;
    }

    public HashSet<Pineapple> getPineapples() {
        return pineapples;
    }
}
