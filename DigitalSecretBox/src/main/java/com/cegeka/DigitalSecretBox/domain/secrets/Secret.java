package com.cegeka.DigitalSecretBox.domain.secrets;

import com.cegeka.DigitalSecretBox.domain.pineapples.Pineapple;

public class Secret {

    public String pictureLocation;
    public String description;
    public Pineapple pineApple;

    public Secret(String description, Pineapple pineApple) {
        this.pictureLocation = pictureLocation;
        this.description = description;
        this.pineApple = pineApple;

    }

    public static String getSecret(Secret secret) {
        return secret.getPhotoLocation() + secret.getDescription();
    }

    public String getPhotoLocation() {
        return pictureLocation;
    }

    public String getDescription() {
        return description;
    }

    public Pineapple getPineApple() {
        return pineApple;
    }
}