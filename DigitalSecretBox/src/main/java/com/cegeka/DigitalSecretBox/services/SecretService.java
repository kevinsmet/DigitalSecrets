package com.cegeka.DigitalSecretBox.services;

import com.cegeka.DigitalSecretBox.domain.pineapples.Pineapple;
import com.cegeka.DigitalSecretBox.domain.pineapples.PineappleRepository;
import com.cegeka.DigitalSecretBox.domain.secrets.Secret;
import com.cegeka.DigitalSecretBox.domain.secrets.SecretRepository;
import org.springframework.stereotype.Controller;

import javax.inject.Inject;
import java.util.List;

@Controller
public class SecretService {

    @Inject
    private PineappleRepository pineappleRepository;

    @Inject
    private SecretRepository secretRepository;

    public void addSecret(String description, String firstName, String lastName) {
        SecretRepository.addSecret(description, firstName, lastName);
    }

    public void getSecret(Secret secret) {
        SecretRepository.getSecret(secret);
    }

    public void getPineApple(Pineapple pineapple) {
        SecretRepository.getPineApple(pineapple);
    }

    public List<Secret> getAllSecrets() {
        return secretRepository.getAllSecrets();
    }

}