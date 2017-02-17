package com.cegeka.DigitalSecretBox.services;

import com.cegeka.DigitalSecretBox.domain.pineapples.Pineapple;
import com.cegeka.DigitalSecretBox.domain.pineapples.PineappleRepository;
import com.cegeka.DigitalSecretBox.domain.secrets.Secret;
import com.cegeka.DigitalSecretBox.domain.secrets.SecretRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;

import java.util.List;

@Controller
public class SecretService {

    @Autowired
    private PineappleRepository pineappleRepository;

    @Autowired
    private SecretRepository secretRepository;

    public void addSecret(Secret secret)
    {
        SecretRepository.addSecret(secret);
    }

    public void getSecret(Secret secret){
        SecretRepository.getSecret(secret);
    }
    public void getPineApple(Pineapple pineapple)
    {
        SecretRepository.getPineApple(pineapple);
    }
    public List<Secret> getAllSecrets()
    {
       return secretRepository.getAllSecrets();
    }


}
