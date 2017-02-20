package com.cegeka.DigitalSecretBox.domain.pineapples;

import javax.inject.Named;
import java.util.HashSet;

@Named
public class PineappleRepository {

    public HashSet<Pineapple> pineapples = new HashSet<>();

    public HashSet<Pineapple> getPineapples() {
        return pineapples;
    }
}
