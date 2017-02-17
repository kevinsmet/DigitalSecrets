package com.cegeka.DigitalSecretBox.domain.secrets;

import com.cegeka.DigitalSecretBox.domain.pineapples.Pineapple;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;

@Component
public class SecretRepository {

    public static List<Secret> secrets = new ArrayList<Secret>();

    public static Pineapple pineApple;

    public SecretRepository(List<Secret> secrets) {
        this.secrets = secrets;
    }

    public static void getSecret(Secret secret) {
        Secret.getSecret(secret);
    }

    public static void getPineApple(Pineapple pineApple) {
        Pineapple.getPineApple(pineApple);
    }


    public List<Secret> getSecrets() {
        return secrets;
    }

    public void setSecrets(List<Secret> secrets) {
        this.secrets = secrets;
    }

    public static void addSecret(Secret secret) {
        secrets.add(secret);
    }

    public List<Secret> getAllSecrets() {
        return secrets;
    }
}