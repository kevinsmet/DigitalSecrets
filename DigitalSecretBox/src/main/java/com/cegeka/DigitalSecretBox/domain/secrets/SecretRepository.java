package com.cegeka.DigitalSecretBox.domain.secrets;

import com.cegeka.DigitalSecretBox.domain.pineapples.Pineapple;
import org.springframework.stereotype.Component;

import javax.inject.Named;
import java.util.ArrayList;
import java.util.List;

@Named
public class SecretRepository {

    public static List<Secret> secrets = new ArrayList<Secret>();

    public static Pineapple pineApple;
    public static Secret secret;

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

    public static void addSecret(String description,String firstName, String lastName)
     {
         pineApple = new Pineapple(firstName,lastName);
         secret = new Secret(description,pineApple);
        secrets.add(secret);
    }

    public List<Secret> getAllSecrets() {
        return secrets;
    }
}